using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToDoList.Structures;

namespace ToDoList.Forms
{
    public partial class ShowTaskForm : Form
    {
        private User authUser;
        private Task showTask;
        public ShowTaskForm(User authUser, Task showTask)
        {
            InitializeComponent();

            this.authUser = authUser;
            this.showTask = showTask;

            taskTitleTb.Text = this.showTask.Name.ToString();
            taskStatusTb.Text = this.showTask.Status.ToString();
            taskDescriptionRtb.Text = this.showTask.Description.ToString();
            taskDateExpiredDTP.Value = this.showTask.ExpiredAt;
            taskTimeExpiredDTP.Value = this.showTask.ExpiredAt;
            taskDateAddDTP.Value = this.showTask.CreatedAt;
            taskTimeAddDTP.Value = this.showTask.CreatedAt;
            if (this.showTask.CloseAt == null)
            {
                taskDateCloseDTP.Format = DateTimePickerFormat.Custom;
                taskDateCloseDTP.CustomFormat = " ";
                taskTimeCloseDTP.Format = DateTimePickerFormat.Custom;
                taskTimeCloseDTP.CustomFormat = " ";
            }
            else
            {
                DateTime closeAt = (DateTime)this.showTask.CloseAt;
                taskDateCloseDTP.Value = closeAt;
                taskTimeCloseDTP.Value = closeAt;
            }


        }

        private void ShowTaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
