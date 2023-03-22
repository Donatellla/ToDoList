using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToDoList.Structures;
using ToDoList.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        private User authUser = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void tasksForm_Load(object sender, EventArgs e)
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

            List<Task> allTasks = Task.GetAllTasks(this.authUser);
            TabPage allTasksTabPage = tasksTC.TabPages.Cast<TabPage>().ToList().Find(x => x.Name == "allTabPage");
            DataGridView allDataGridView = this.GetDataGrinViewOnTabControl(allTasksTabPage, "tasksAllDG");
            this.DrawTasks(allTasks, allDataGridView);

            List<Task> newTasks = Task.GetAllTasks(this.authUser, Task.STATUS_NEW);
            TabPage newTasksTabPage = tasksTC.TabPages.Cast<TabPage>().ToList().Find(x => x.Name == "newTabPage");
            DataGridView newDataGridView = this.GetDataGrinViewOnTabControl(newTasksTabPage, "tasksNewDG");
            this.DrawTasks(newTasks, newDataGridView);

            List<Task> closeTasks = Task.GetAllTasks(this.authUser, Task.STATUS_CLOSE);
            TabPage closeTasksTabPage = tasksTC.TabPages.Cast<TabPage>().ToList().Find(x => x.Name == "closeTabPage");
            DataGridView closeDataGridView = this.GetDataGrinViewOnTabControl(closeTasksTabPage, "tasksCloseDG");
            this.DrawTasks(closeTasks, closeDataGridView);
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

        private void deleteTaskBtn_Click(object sender, EventArgs e)
        {
            Result deletResult = null;

            DataGridView selectedDataGridView = this.GetDataGrinViewOnTabControl(tasksTC.SelectedTab);
            if (selectedDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = selectedDataGridView.SelectedRows[0];
                int taskId = (int)selectedRow.Cells[0].Value;

                if (taskId > 0)
                {
                    deletResult = Task.DeleteById(taskId);

                }
            }

            MessageBox.Show(
                deletResult != null ? deletResult.Message : "Не выбрана задача для удаления.",
                "Результат удаления",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );

            List<Task> allTasks = Task.GetAllTasks(this.authUser);
            TabPage allTasksTabPage = tasksTC.TabPages.Cast<TabPage>().ToList().Find(x => x.Name == "allTabPage");
            DataGridView allDataGridView = this.GetDataGrinViewOnTabControl(allTasksTabPage, "tasksAllDG");
            this.DrawTasks(allTasks, allDataGridView);

            List<Task> newTasks = Task.GetAllTasks(this.authUser, Task.STATUS_NEW);
            TabPage newTasksTabPage = tasksTC.TabPages.Cast<TabPage>().ToList().Find(x => x.Name == "newTabPage");
            DataGridView newDataGridView = this.GetDataGrinViewOnTabControl(newTasksTabPage, "tasksNewDG");
            this.DrawTasks(newTasks, newDataGridView);

            List<Task> closeTasks = Task.GetAllTasks(this.authUser, Task.STATUS_CLOSE);
            TabPage closeTasksTabPage = tasksTC.TabPages.Cast<TabPage>().ToList().Find(x => x.Name == "closeTabPage");
            DataGridView closeDataGridView = this.GetDataGrinViewOnTabControl(closeTasksTabPage, "tasksCloseDG");
            this.DrawTasks(closeTasks, closeDataGridView);
        }

        private void taskEditBtn_Click(object sender, EventArgs e)
        {
            DataGridView selectedDataGridView = this.GetDataGrinViewOnTabControl(tasksTC.SelectedTab);

            if (selectedDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = selectedDataGridView.SelectedRows[0];
                int taskId = (int)selectedRow.Cells[0].Value;

                if (taskId > 0)
                {
                    Task selectedTask = new Task();
                    Result loadResult = selectedTask.LoadById(taskId);

                    if (loadResult.IsSuccess)
                    {
                        EditTaskForm editTaskForm = new EditTaskForm(this.authUser, selectedTask);
                        editTaskForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(
                            loadResult.Message,
                            "Результат обновления",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Не выбрана задача для редактирования.",
                        "Результат обновления",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1
                    );
                }
            }

            List<Task> allTasks = Task.GetAllTasks(this.authUser);
            TabPage allTasksTabPage = tasksTC.TabPages.Cast<TabPage>().ToList().Find(x => x.Name == "allTabPage");
            DataGridView allDataGridView = this.GetDataGrinViewOnTabControl(allTasksTabPage, "tasksAllDG");
            this.DrawTasks(allTasks, allDataGridView);

            List<Task> newTasks = Task.GetAllTasks(this.authUser, Task.STATUS_NEW);
            TabPage newTasksTabPage = tasksTC.TabPages.Cast<TabPage>().ToList().Find(x => x.Name == "newTabPage");
            DataGridView newDataGridView = this.GetDataGrinViewOnTabControl(newTasksTabPage, "tasksNewDG");
            this.DrawTasks(newTasks, newDataGridView);

            List<Task> closeTasks = Task.GetAllTasks(this.authUser, Task.STATUS_CLOSE);
            TabPage closeTasksTabPage = tasksTC.TabPages.Cast<TabPage>().ToList().Find(x => x.Name == "closeTabPage");
            DataGridView closeDataGridView = this.GetDataGrinViewOnTabControl(closeTasksTabPage, "tasksCloseDG");
            this.DrawTasks(closeTasks, closeDataGridView);
        }

        private void closeTaskBtn_Click(object sender, EventArgs e)
        {
            Result closeResult = null;

            DataGridView selectedDataGridView = this.GetDataGrinViewOnTabControl(tasksTC.SelectedTab);
            if (selectedDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = selectedDataGridView.SelectedRows[0];
                int taskId = (int)selectedRow.Cells[0].Value;

                if (taskId > 0)
                {
                    Task selectedTask = new Task();
                    Result loadResult = selectedTask.LoadById(taskId);

                    if (loadResult.IsSuccess)
                    {
                        //ToDo проверить работоспсобность
                        selectedTask.CloseAt = DateTime.Now;
                        selectedTask.Status = Task.STATUS_CLOSE;
                        closeResult = selectedTask.UpdateInDB();
                    }
                    else
                    {
                        closeResult = loadResult;
                    }

                }
            }

            MessageBox.Show(
                closeResult != null ? closeResult.Message : "Не выбрана задача.",
                 "Изменение статуса задачи",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );

            List<Task> allTasks = Task.GetAllTasks(this.authUser);
            TabPage allTasksTabPage = tasksTC.TabPages.Cast<TabPage>().ToList().Find(x => x.Name == "allTabPage");
            DataGridView allDataGridView = this.GetDataGrinViewOnTabControl(allTasksTabPage, "tasksAllDG");
            this.DrawTasks(allTasks, allDataGridView);

            List<Task> newTasks = Task.GetAllTasks(this.authUser, Task.STATUS_NEW);
            TabPage newTasksTabPage = tasksTC.TabPages.Cast<TabPage>().ToList().Find(x => x.Name == "newTabPage");
            DataGridView newDataGridView = this.GetDataGrinViewOnTabControl(newTasksTabPage, "tasksNewDG");
            this.DrawTasks(newTasks, newDataGridView);

            List<Task> closeTasks = Task.GetAllTasks(this.authUser, Task.STATUS_CLOSE);
            TabPage closeTasksTabPage = tasksTC.TabPages.Cast<TabPage>().ToList().Find(x => x.Name == "closeTabPage");
            DataGridView closeDataGridView = this.GetDataGrinViewOnTabControl(closeTasksTabPage, "tasksCloseDG");
            this.DrawTasks(closeTasks, closeDataGridView);

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

        private void tasksNewDG_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView selectedDataGridView = this.GetDataGrinViewOnTabControl(tasksTC.SelectedTab);

            if (selectedDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = selectedDataGridView.SelectedRows[0];
                int taskId = (int)selectedRow.Cells[0].Value;

                if (taskId > 0)
                {
                    Task selectedTask = new Task();
                    Result loadResult = selectedTask.LoadById(taskId);

                    if (loadResult.IsSuccess)
                    {
                        ShowTaskForm showTaskForm = new ShowTaskForm(this.authUser, selectedTask);
                        showTaskForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(
                            loadResult.Message,
                            "Результат просмотра",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Не выбрана задача для просмотра.",
                        "Результат просмотра",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1
                    );
                }
            }
        }

        private void tasksCloseDG_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView selectedDataGridView = this.GetDataGrinViewOnTabControl(tasksTC.SelectedTab);

            if (selectedDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = selectedDataGridView.SelectedRows[0];
                int taskId = (int)selectedRow.Cells[0].Value;

                if (taskId > 0)
                {
                    Task selectedTask = new Task();
                    Result loadResult = selectedTask.LoadById(taskId);

                    if (loadResult.IsSuccess)
                    {
                        ShowTaskForm showTaskForm = new ShowTaskForm(this.authUser, selectedTask);
                        showTaskForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(
                            loadResult.Message,
                            "Результат просмотра",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Не выбрана задача для просмотра.",
                        "Результат просмотра",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1
                    );
                }
            }
        }

        private void tasksAllDG_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView selectedDataGridView = this.GetDataGrinViewOnTabControl(tasksTC.SelectedTab);

            if (selectedDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = selectedDataGridView.SelectedRows[0];
                int taskId = (int)selectedRow.Cells[0].Value;

                if (taskId > 0)
                {
                    Task selectedTask = new Task();
                    Result loadResult = selectedTask.LoadById(taskId);

                    if (loadResult.IsSuccess)
                    {
                        ShowTaskForm showTaskForm = new ShowTaskForm(this.authUser, selectedTask);
                        showTaskForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(
                            loadResult.Message,
                            "Результат просмотра",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Не выбрана задача для просмотра.",
                        "Результат просмотра",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1
                    );
                }
            }
        }

        private void tasksNewDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
