namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tasksTC = new System.Windows.Forms.TabControl();
            this.newTabPage = new System.Windows.Forms.TabPage();
            this.tasksNewDG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeTabPage = new System.Windows.Forms.TabPage();
            this.tasksCloseDG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allTabPage = new System.Windows.Forms.TabPage();
            this.tasksAllDG = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.deleteTaskBtn = new System.Windows.Forms.Button();
            this.taskEditBtn = new System.Windows.Forms.Button();
            this.closeTaskBtn = new System.Windows.Forms.Button();
            this.tasksTC.SuspendLayout();
            this.newTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksNewDG)).BeginInit();
            this.closeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksCloseDG)).BeginInit();
            this.allTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksAllDG)).BeginInit();
            this.SuspendLayout();
            // 
            // tasksTC
            // 
            this.tasksTC.Controls.Add(this.newTabPage);
            this.tasksTC.Controls.Add(this.closeTabPage);
            this.tasksTC.Controls.Add(this.allTabPage);
            this.tasksTC.Location = new System.Drawing.Point(242, 30);
            this.tasksTC.Name = "tasksTC";
            this.tasksTC.SelectedIndex = 0;
            this.tasksTC.Size = new System.Drawing.Size(857, 578);
            this.tasksTC.TabIndex = 6;
            // 
            // newTabPage
            // 
            this.newTabPage.Controls.Add(this.tasksNewDG);
            this.newTabPage.Location = new System.Drawing.Point(4, 25);
            this.newTabPage.Name = "newTabPage";
            this.newTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.newTabPage.Size = new System.Drawing.Size(849, 549);
            this.newTabPage.TabIndex = 0;
            this.newTabPage.Text = "Текущие задачи";
            this.newTabPage.UseVisualStyleBackColor = true;
            // 
            // tasksNewDG
            // 
            this.tasksNewDG.AllowUserToAddRows = false;
            this.tasksNewDG.AllowUserToDeleteRows = false;
            this.tasksNewDG.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tasksNewDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tasksNewDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksNewDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tasksNewDG.DefaultCellStyle = dataGridViewCellStyle14;
            this.tasksNewDG.GridColor = System.Drawing.Color.MistyRose;
            this.tasksNewDG.Location = new System.Drawing.Point(0, 2);
            this.tasksNewDG.Margin = new System.Windows.Forms.Padding(4);
            this.tasksNewDG.MultiSelect = false;
            this.tasksNewDG.Name = "tasksNewDG";
            this.tasksNewDG.ReadOnly = true;
            this.tasksNewDG.RowHeadersVisible = false;
            this.tasksNewDG.RowHeadersWidth = 51;
            this.tasksNewDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tasksNewDG.Size = new System.Drawing.Size(845, 543);
            this.tasksNewDG.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Title";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Date Create";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Date Expired";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Date Close";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Status";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // closeTabPage
            // 
            this.closeTabPage.Controls.Add(this.tasksCloseDG);
            this.closeTabPage.Location = new System.Drawing.Point(4, 25);
            this.closeTabPage.Name = "closeTabPage";
            this.closeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.closeTabPage.Size = new System.Drawing.Size(849, 549);
            this.closeTabPage.TabIndex = 1;
            this.closeTabPage.Text = "Закрытые задачи";
            this.closeTabPage.UseVisualStyleBackColor = true;
            // 
            // tasksCloseDG
            // 
            this.tasksCloseDG.AllowUserToAddRows = false;
            this.tasksCloseDG.AllowUserToDeleteRows = false;
            this.tasksCloseDG.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tasksCloseDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.tasksCloseDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksCloseDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tasksCloseDG.DefaultCellStyle = dataGridViewCellStyle16;
            this.tasksCloseDG.GridColor = System.Drawing.Color.MistyRose;
            this.tasksCloseDG.Location = new System.Drawing.Point(0, 2);
            this.tasksCloseDG.Margin = new System.Windows.Forms.Padding(4);
            this.tasksCloseDG.MultiSelect = false;
            this.tasksCloseDG.Name = "tasksCloseDG";
            this.tasksCloseDG.ReadOnly = true;
            this.tasksCloseDG.RowHeadersVisible = false;
            this.tasksCloseDG.RowHeadersWidth = 51;
            this.tasksCloseDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tasksCloseDG.Size = new System.Drawing.Size(845, 543);
            this.tasksCloseDG.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Date Create";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Date Expired";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Date Close";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // allTabPage
            // 
            this.allTabPage.Controls.Add(this.tasksAllDG);
            this.allTabPage.Location = new System.Drawing.Point(4, 25);
            this.allTabPage.Name = "allTabPage";
            this.allTabPage.Size = new System.Drawing.Size(849, 549);
            this.allTabPage.TabIndex = 2;
            this.allTabPage.Text = "Список задач";
            this.allTabPage.UseVisualStyleBackColor = true;
            // 
            // tasksAllDG
            // 
            this.tasksAllDG.AllowUserToAddRows = false;
            this.tasksAllDG.AllowUserToDeleteRows = false;
            this.tasksAllDG.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tasksAllDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.tasksAllDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksAllDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.createdAt,
            this.expiredAt,
            this.closeAt,
            this.status});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tasksAllDG.DefaultCellStyle = dataGridViewCellStyle18;
            this.tasksAllDG.GridColor = System.Drawing.Color.MistyRose;
            this.tasksAllDG.Location = new System.Drawing.Point(0, 2);
            this.tasksAllDG.Margin = new System.Windows.Forms.Padding(4);
            this.tasksAllDG.MultiSelect = false;
            this.tasksAllDG.Name = "tasksAllDG";
            this.tasksAllDG.ReadOnly = true;
            this.tasksAllDG.RowHeadersVisible = false;
            this.tasksAllDG.RowHeadersWidth = 51;
            this.tasksAllDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tasksAllDG.Size = new System.Drawing.Size(845, 543);
            this.tasksAllDG.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 125;
            // 
            // createdAt
            // 
            this.createdAt.HeaderText = "Date Create";
            this.createdAt.MinimumWidth = 6;
            this.createdAt.Name = "createdAt";
            this.createdAt.ReadOnly = true;
            this.createdAt.Width = 125;
            // 
            // expiredAt
            // 
            this.expiredAt.HeaderText = "Date Expired";
            this.expiredAt.MinimumWidth = 6;
            this.expiredAt.Name = "expiredAt";
            this.expiredAt.ReadOnly = true;
            this.expiredAt.Width = 125;
            // 
            // closeAt
            // 
            this.closeAt.HeaderText = "Date Close";
            this.closeAt.MinimumWidth = 6;
            this.closeAt.Name = "closeAt";
            this.closeAt.ReadOnly = true;
            this.closeAt.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Location = new System.Drawing.Point(26, 30);
            this.addTaskBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(189, 28);
            this.addTaskBtn.TabIndex = 3;
            this.addTaskBtn.Text = "Добавить задачу";
            this.addTaskBtn.UseVisualStyleBackColor = true;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // deleteTaskBtn
            // 
            this.deleteTaskBtn.Location = new System.Drawing.Point(26, 75);
            this.deleteTaskBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteTaskBtn.Name = "deleteTaskBtn";
            this.deleteTaskBtn.Size = new System.Drawing.Size(189, 28);
            this.deleteTaskBtn.TabIndex = 3;
            this.deleteTaskBtn.Text = "Удалить задачу";
            this.deleteTaskBtn.UseVisualStyleBackColor = true;
            this.deleteTaskBtn.Click += new System.EventHandler(this.deleteTaskBtn_Click);
            // 
            // taskEditBtn
            // 
            this.taskEditBtn.Location = new System.Drawing.Point(26, 111);
            this.taskEditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.taskEditBtn.Name = "taskEditBtn";
            this.taskEditBtn.Size = new System.Drawing.Size(189, 28);
            this.taskEditBtn.TabIndex = 7;
            this.taskEditBtn.Text = "Редактировать задачу";
            this.taskEditBtn.UseVisualStyleBackColor = true;
            this.taskEditBtn.Click += new System.EventHandler(this.taskEditBtn_Click);
            // 
            // closeTaskBtn
            // 
            this.closeTaskBtn.Location = new System.Drawing.Point(26, 147);
            this.closeTaskBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeTaskBtn.Name = "closeTaskBtn";
            this.closeTaskBtn.Size = new System.Drawing.Size(189, 28);
            this.closeTaskBtn.TabIndex = 8;
            this.closeTaskBtn.Text = "Закрыть задачу";
            this.closeTaskBtn.UseVisualStyleBackColor = true;
            this.closeTaskBtn.Click += new System.EventHandler(this.closeTaskBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 620);
            this.Controls.Add(this.closeTaskBtn);
            this.Controls.Add(this.taskEditBtn);
            this.Controls.Add(this.deleteTaskBtn);
            this.Controls.Add(this.addTaskBtn);
            this.Controls.Add(this.tasksTC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tasksTC.ResumeLayout(false);
            this.newTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tasksNewDG)).EndInit();
            this.closeTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tasksCloseDG)).EndInit();
            this.allTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tasksAllDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tasksTC;
        private System.Windows.Forms.TabPage newTabPage;
        private System.Windows.Forms.DataGridView tasksNewDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TabPage closeTabPage;
        private System.Windows.Forms.DataGridView tasksCloseDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabPage allTabPage;
        private System.Windows.Forms.DataGridView tasksAllDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button addTaskBtn;
        private System.Windows.Forms.Button deleteTaskBtn;
        private System.Windows.Forms.Button taskEditBtn;
        private System.Windows.Forms.Button closeTaskBtn;
    }
}

