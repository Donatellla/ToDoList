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
    public partial class EditTaskForm : Form
    {
        private User authUser;
        private Task editTask;
        public EditTaskForm(User authUser, Task editTask)
        {
            InitializeComponent();

            this.authUser = authUser;
            this.editTask = editTask;

            taskTitleTb.Text = this.editTask.Name.ToString();
            taskDescriptionRtb.Text = this.editTask.Description.ToString();
            taskDateExpiredDTP.Value = this.editTask.ExpiredAt;
            taskTimeExpiredDTP.Value = this.editTask.ExpiredAt;

        }
        private void updateTaskBtn_Click(object sender, EventArgs e)
        {
            string title = taskTitleTb.Text;
            string description = taskDescriptionRtb.Text;
            DateTime expiredAt = taskDateExpiredDTP.Value.Date + taskTimeExpiredDTP.Value.TimeOfDay;

            Result addResult = new Result();

            this.editTask.Name = title;
            this.editTask.Description = description;
            this.editTask.ExpiredAt = expiredAt;

            Result validatedResult = editTask.Validate();
            if (validatedResult.IsSuccess)
            {
                addResult = editTask.UpdateInDB();
            }
            else
            {
                addResult = validatedResult;
            }

            MessageBox.Show(
                addResult.Message,
                "Результат редактирования",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );
            this.Close();
        }
    }
}
