using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Data.SqlClient;
using static Mysqlx.Notice.SessionStateChanged.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ToDoList.Structures
{
    public class User
    {
        private int id;
        private string login;
        private string password;
        private string hash_password;

        public User()
        {
        }

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public User(int id, string login, string password)
        {
            this.id = id;
            this.login = login;
            this.password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Hash_password { get => hash_password; set => hash_password = value; }
        public string Password { get => password; set => password = value; }

        public Result Validate(bool needValidatePawword = false)
        {
            Result validateResult = new Result(true, "");

            if (this.login == "")
            {
                validateResult.IsSuccess = false;
                validateResult.Message = "Отсутсвует логин";
            }

            if (needValidatePawword && this.password == "")
            {
                validateResult.IsSuccess = false;

                if (validateResult.Message == "")
                {
                    validateResult.Message = "Отсутсвует пароль";
                }
                else
                {
                    validateResult.Message += ", отсутсвует пароль";
                }

            }

            return validateResult;


        }

        public Result AddToDB()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            this.hash_password = Convert.ToBase64String(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(this.password)));
            
            string sql = "INSERT INTO `users` (`id`, `login`, `password`) VALUES (NULL, @login, @hash_password);";
            
            // Создать объект Command.
            MySqlCommand cmd = new MySqlCommand();

            cmd.Parameters.AddWithValue("@login", this.login);
            cmd.Parameters.AddWithValue("@hash_password", this.hash_password);

            // Сочетать Command с Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;

            Result result = new Result();

            try
            {
                int insertedRowCount = cmd.ExecuteNonQuery();

                if (insertedRowCount == 1)
                {
                    this.id = (int)cmd.LastInsertedId;
                    this.password = null;
                    result = new Result(true, "Пользователь успешно добавлен.");
                }
                else
                {
                    result = new Result(false, "Ошибка добавления в базу.");
                }
            }
            catch (Exception e)
            {
                if (e.Message == "Duplicate entry 'user' for key 'users.unique_login'")
                {
                    result = new Result(false, "Пользователь с таким логином уже существует.");
                }
                else
                {
                    result = new Result(false, e.Message);
                }
            }

            conn.Close();

            return result;
        }

        public Result LoginUser(string inpuLogin, string inputPassword)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sql = "SELECT * FROM `users` WHERE login= @Login";

            // Создать объект Command.
            MySqlCommand cmd = new MySqlCommand();
            cmd.Parameters.AddWithValue("@Login", inpuLogin);

            // Сочетать Command с Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;

            Result result = new Result();

            try
            {
                DbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = (int)reader.GetValue(reader.GetOrdinal("id"));
                        string login = (string)reader.GetValue(reader.GetOrdinal("login"));
                        string hashPassword = (string)reader.GetValue(reader.GetOrdinal("password"));

                        this.id = id;
                        this.login = login;
                        this.hash_password = hashPassword;
                    }

                    string tmpHash = Convert.ToBase64String(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(inputPassword)));

                    if (this.hash_password == tmpHash)
                    {
                        result = new Result(true, "");
                    }
                    else
                    {
                        result = new Result(false, "Пароль неверный.");
                    }
                }
                else
                {
                    result = new Result(false, "Пользователь не найден.");
                }

            }
            catch (Exception e)
            {
                result = new Result(false, e.Message);
            }

            conn.Close();

            return result;
        }
    }
}
