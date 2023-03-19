using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Forms;
using ToDoList.Structures;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        private User authUser = null;
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.authUser == null)
            {
                AuthForm authForm = new AuthForm();
                authForm.ShowDialog();

                this.authUser = authForm.AuthUser;
                if (this.authUser == null)
                {
                    this.Close();
                    return;
                }
            }
        }
    }
}
