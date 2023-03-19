using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Structures;

namespace ToDoList.Forms
{
    public partial class AuthForm : Form
    {
        private User authUser = null;
        public AuthForm()
        {
            InitializeComponent();
        }

        public User AuthUser { get => authUser; set => authUser = value; }

        private void authBtn_Click(object sender, EventArgs e)
        {
            string login = loginTb.Text;
            string password = passwordTb.Text;

            User userForAuth = new User();
            Result getResult = userForAuth.LoginUser(login, password);

            if (getResult.IsSuccess)
            {
                this.authUser = userForAuth;
                this.Close();
            }
            else
            {
                resultLbl.Text = getResult.Message;
            }
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            string login = loginTb.Text;
            string password = passwordTb.Text;

            User userForAdd = new User(login, password);
            Result validatedResult = userForAdd.Validate(true);

            Result addResult = new Result();
            if (validatedResult.IsSuccess)
            {
                addResult = userForAdd.AddToDB();
            }
            else
            {
                addResult = validatedResult;
            }

            MessageBox.Show(
               addResult.Message,
               "Результат добавления",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1
           );
        }
    }
}
