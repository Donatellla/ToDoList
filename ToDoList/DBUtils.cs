using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = DBConnectionConfig.host;
            int port = DBConnectionConfig.port;
            string database = DBConnectionConfig.database;
            string username = DBConnectionConfig.username;
            string password = DBConnectionConfig.password;

            var connection = DBMySQLUtils.GetDBConnection(host, port, database, username, password);
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(
                "Отсутсвует соединение",
                "Результат проверки",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
                );
                Application.Exit();
            }

             return connection; 
        }
    }
}
