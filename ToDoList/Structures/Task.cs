using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Structures
{
    public class Task
    {
        private static readonly string DATE_FORMAT = "yyyy-MM-dd H:mm:ss";
        public static readonly string STATUS_NEW = "new";
        public static readonly string STATUS_CLOSE = "close";

        private int id;
        private string name;
        private string description;
        private DateTime createdAt;
        private DateTime? closeAt;
        private DateTime expiredAt;
        private string status;
        private int userId = 0;

        public Task()
        {

        }

        public Task(string name, string description, DateTime createdAt, DateTime expiredAt, DateTime? closeAt, string status, int userId)
        {
            this.name = name;
            this.description = description;
            this.createdAt = createdAt;
            this.closeAt = closeAt;
            this.expiredAt = expiredAt;
            this.status = status;
            this.userId = userId;
        }

        public Task(int id, string name, string description, DateTime createdAt, DateTime expiredAt, DateTime? closeAt, string status, int userId)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.createdAt = createdAt;
            this.closeAt = closeAt;
            this.expiredAt = expiredAt;
            this.status = status;
            this.userId = userId;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime ExpiredAt { get => expiredAt; set => expiredAt = value; }
        public string Status { get => status; set => status = value; }
        public int UserId { get => userId; set => userId = value; }
        public DateTime? CloseAt { get => closeAt; set => closeAt = value; }

        public Result Validate()
        {
            Result validateResult = new Result(true, "");

            if (this.name == "")
            {
                validateResult.IsSuccess = false;
                validateResult.Message = "Отсутсвует наименование задачи";
            }

            if (this.userId == 0)
            {
                validateResult.IsSuccess = false;

                if (validateResult.Message == "")
                {
                    validateResult.Message = "Не установлен id пользователя";
                }
                else
                {
                    validateResult.Message += ", не установлен id пользователя";
                }

            }

            return validateResult;


        }


        public Result AddToDB()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string dateClose = "NULL";
            if (this.closeAt != null)
            {
                DateTime dateTimeClose = (DateTime)this.closeAt;
                dateClose = "'" + dateTimeClose.ToString(Task.DATE_FORMAT) + "'";
            }

            string sql = "INSERT INTO `tasks` (`id`, `title`, `description`, `created_at`, `expired_at`, `close_at`, `status`, `user_id`) " +
                "VALUES (NULL, '" + this.name + "', '" + this.description + "', '" + this.createdAt.ToString(Task.DATE_FORMAT) + "', '" + this.expiredAt.ToString(Task.DATE_FORMAT) + "', " + dateClose + ", '" + this.status + "', '" + this.userId + "');";

            // Создать объект Command.
            MySqlCommand cmd = new MySqlCommand();

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
                    result = new Result(true, "Задача успешно добавлена.");
                }
                else
                {
                    result = new Result(false, "Ошибка добавления в базу.");
                }
            }
            catch (Exception e)
            {
                //ToDo переопределить текст ошибки
                result = new Result(false, e.Message);
            }

            conn.Close();

            return result;
        }

        public Result UpdateInDB()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string dateClose = "NULL";
            if (this.closeAt != null)
            {
                DateTime dateTimeClose = (DateTime)this.closeAt;
                dateClose = "'" + dateTimeClose.ToString(Task.DATE_FORMAT) + "'";
            }

            string sql = "UPDATE `tasks` SET " +
                "`title` = '" + this.name + "', " +
                "`description` = '" + this.description + "', " +
                "`created_at` = '" + this.createdAt.ToString(Task.DATE_FORMAT) + "', " +
                "`expired_at` = '" + this.expiredAt.ToString(Task.DATE_FORMAT) + "', " +
                "`close_at` = " + dateClose + ", " +
                "`status` = '" + this.status + "', " +
                "`user_id` = '" + this.userId + "' " +
                "WHERE `tasks`.`id` = " + this.id;

            // Создать объект Command.
            MySqlCommand cmd = new MySqlCommand();

            // Сочетать Command с Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;

            Result result = new Result();

            try
            {
                int insertedRowCount = cmd.ExecuteNonQuery();

                if (insertedRowCount == 1)
                {
                    result = new Result(true, "Задача успешно обновлена.");
                }
                else
                {
                    result = new Result(false, "Ошибка обновленаия.");
                }
            }
            catch (Exception e)
            {
                //ToDo переопределить текст ошибки
                result = new Result(false, e.Message);
            }

            conn.Close();

            return result;
        }

        public static List<Task> GetAllTasks(User user, string inputStatus = "")
        {
            List<Task> allTasks = new List<Task>();

            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sql = "SELECT * FROM `tasks` WHERE user_id = " + user.Id;

            if (inputStatus != "")
            {
                sql += " AND status = '" + inputStatus + "'";
            }

            // Создать объект Command.
            MySqlCommand cmd = new MySqlCommand();

            // Сочетать Command с Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;

            try
            {
                DbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = (int)reader.GetValue(reader.GetOrdinal("id"));
                        string title = (string)reader.GetValue(reader.GetOrdinal("title"));
                        string description = (string)reader.GetValue(reader.GetOrdinal("description"));
                        DateTime createdAt = (DateTime)reader.GetValue(reader.GetOrdinal("created_at"));
                        DateTime expiredAt = (DateTime)reader.GetValue(reader.GetOrdinal("expired_at"));
                        string status = (string)reader.GetValue(reader.GetOrdinal("status"));
                        int userId = (int)reader.GetValue(reader.GetOrdinal("user_id"));

                        DateTime? closeAt = null;
                        var closeAtObject = reader.GetValue(reader.GetOrdinal("close_at")).ToString();
                        if (closeAtObject != "")
                        {
                            closeAt = (DateTime)reader.GetValue(reader.GetOrdinal("close_at"));
                        }

                        Task tmpTask = new Task(id, title, description, createdAt, expiredAt, closeAt, status, userId);
                        allTasks.Add(tmpTask);
                    }
                }
            }
            catch (Exception e)
            {
            }

            conn.Close();

            return allTasks;
        }

        public Result LoadById(int inputId)
        {
            Result result = new Result();

            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sql = "SELECT * FROM `tasks` WHERE id = " + inputId;

            // Создать объект Command.
            MySqlCommand cmd = new MySqlCommand();

            // Сочетать Command с Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;

            try
            {
                DbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = (int)reader.GetValue(reader.GetOrdinal("id"));
                        string title = (string)reader.GetValue(reader.GetOrdinal("title"));
                        string description = (string)reader.GetValue(reader.GetOrdinal("description"));
                        DateTime createdAt = (DateTime)reader.GetValue(reader.GetOrdinal("created_at"));
                        DateTime expiredAt = (DateTime)reader.GetValue(reader.GetOrdinal("expired_at"));
                        string status = (string)reader.GetValue(reader.GetOrdinal("status"));
                        int userId = (int)reader.GetValue(reader.GetOrdinal("user_id"));

                        DateTime? closeAt = null;
                        var closeAtObject = reader.GetValue(reader.GetOrdinal("close_at")).ToString();
                        if (closeAtObject != "")
                        {
                            closeAt = (DateTime)reader.GetValue(reader.GetOrdinal("close_at"));
                        }

                        this.id = id;
                        this.name = title;
                        this.description = description;
                        this.createdAt = createdAt;
                        this.expiredAt = expiredAt;
                        this.closeAt = closeAt;
                        this.status = status;
                        this.userId = userId;

                        result = new Result(true, "");
                    }
                }
                else
                {
                    result = new Result(false, "Задача не найдена");
                }
            }
            catch (Exception e)
            {
                result = new Result(false, e.Message);
            }

            conn.Close();

            return result;
        }

        public static Result DeleteById(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sql = "DELETE FROM `tasks` WHERE `tasks`.`id` = " + id;
            // Создать объект Command.
            MySqlCommand cmd = new MySqlCommand();

            // Сочетать Command с Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;

            Result result = new Result();

            try
            {
                int deleteCount = cmd.ExecuteNonQuery();

                if (deleteCount == 1)
                {
                    result = new Result(true, "Задача успешно удалена.");
                }
                else
                {
                    result = new Result(false, "Ошибка удаления из базы.");
                }
            }
            catch (Exception e)
            {
                //ToDo переопределить текст ошибки
                result = new Result(false, e.Message);
            }

            conn.Close();

            return result;
        }
    }
}
