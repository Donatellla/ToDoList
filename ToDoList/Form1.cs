﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(this.authUser);
            addTaskForm.ShowDialog();

            List<Task> allTasks = Task.GetAllTasks(this.authUser);
            TabPage allTasksTabPage = tasksTC.TabPages.Cast<TabPage>().ToList().Find(x => x.Name == "allTabPage");
            DataGridView allDataGridView = this.GetDataGrinViewOnTabControl(allTasksTabPage, "tasksAllDG");
            this.DrawTasks(allTasks, allDataGridView);

            List<Task> newTasks = Task.GetAllTasks(this.authUser, Task.STATUS_NEW);
            TabPage newTasksTabPage = tasksTC.TabPages.Cast<TabPage>().ToList().Find(x => x.Name == "newTabPage");
            DataGridView newDataGridView = this.GetDataGrinViewOnTabControl(newTasksTabPage, "tasksNewDG");
            this.DrawTasks(newTasks, newDataGridView);
        }
        private void DrawTasks(List<Task> tasks, Control dataGridViewControl)
        {
            DataGridView dataGridView = (DataGridView)dataGridViewControl;

            dataGridView.Rows.Clear();
            foreach (Task tmpTask in tasks)
            {
                dataGridView.Rows.Add(tmpTask.Id, tmpTask.Name, tmpTask.CreatedAt, tmpTask.ExpiredAt, tmpTask.CloseAt, tmpTask.Status);
            }
        }
        private DataGridView GetDataGrinViewOnTabControl(TabPage tabPage, string nameDatGrid = "")
        {
            foreach (var control in tabPage.Controls)
            {
                string type = control.GetType().Name;
                if (type == "DataGridView")
                {
                    DataGridView dataGridView = (DataGridView)control;

                    if (dataGridView.Name == nameDatGrid || nameDatGrid == "")
                    {
                        return dataGridView;
                    }
                }
            }

            return null;
        }
    }
}
