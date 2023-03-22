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
    public partial class AddTaskForm : Form
    {
        private User authUser;

        public AddTaskForm(User authUser)
        {
            InitializeComponent();

            this.authUser = authUser;
        }

        private void addTaskBtn_Click_1(object sender, EventArgs e)
        {
            string title = taskTitleTb.Text;
            string description = taskDescriptionRtb.Text;
            DateTime expiredAt = taskDateExpiredDTP.Value.Date + taskTimeExpiredDTP.Value.TimeOfDay;

            Result addResult = new Result();

            Task newTask = new Task();
            newTask.Name = title;
            newTask.Description = description;
            newTask.CreatedAt = DateTime.Now;
            newTask.CloseAt = null;
            newTask.ExpiredAt = expiredAt;
            newTask.Status = Task.STATUS_NEW;
            newTask.UserId = this.authUser.Id;

            Result validatedResult = newTask.Validate();
            if (validatedResult.IsSuccess)
            {
                addResult = newTask.AddToDB();
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
