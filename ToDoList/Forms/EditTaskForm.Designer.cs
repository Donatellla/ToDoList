namespace ToDoList.Forms
{
    partial class EditTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskTimeExpiredDTP = new System.Windows.Forms.DateTimePicker();
            this.resultLbl = new System.Windows.Forms.Label();
            this.taskDateExpiredDTP = new System.Windows.Forms.DateTimePicker();
            this.updateTaskBtn = new System.Windows.Forms.Button();
            this.dateExpiresLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taskDescriptionRtb = new System.Windows.Forms.RichTextBox();
            this.taskDescriptionLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taskTitleLbl = new System.Windows.Forms.Label();
            this.taskTitleTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // taskTimeExpiredDTP
            // 
            this.taskTimeExpiredDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.taskTimeExpiredDTP.Location = new System.Drawing.Point(359, 273);
            this.taskTimeExpiredDTP.Margin = new System.Windows.Forms.Padding(4);
            this.taskTimeExpiredDTP.Name = "taskTimeExpiredDTP";
            this.taskTimeExpiredDTP.ShowUpDown = true;
            this.taskTimeExpiredDTP.Size = new System.Drawing.Size(135, 22);
            this.taskTimeExpiredDTP.TabIndex = 21;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(13, 337);
            this.resultLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(12, 17);
            this.resultLbl.TabIndex = 20;
            this.resultLbl.Text = " ";
            // 
            // taskDateExpiredDTP
            // 
            this.taskDateExpiredDTP.Location = new System.Drawing.Point(13, 273);
            this.taskDateExpiredDTP.Margin = new System.Windows.Forms.Padding(4);
            this.taskDateExpiredDTP.Name = "taskDateExpiredDTP";
            this.taskDateExpiredDTP.Size = new System.Drawing.Size(338, 22);
            this.taskDateExpiredDTP.TabIndex = 19;
            // 
            // updateTaskBtn
            // 
            this.updateTaskBtn.Location = new System.Drawing.Point(13, 305);
            this.updateTaskBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateTaskBtn.Name = "updateTaskBtn";
            this.updateTaskBtn.Size = new System.Drawing.Size(481, 28);
            this.updateTaskBtn.TabIndex = 18;
            this.updateTaskBtn.Text = "Обновить задачу";
            this.updateTaskBtn.UseVisualStyleBackColor = true;
            this.updateTaskBtn.Click += new System.EventHandler(this.updateTaskBtn_Click);
            // 
            // dateExpiresLbl
            // 
            this.dateExpiresLbl.AutoSize = true;
            this.dateExpiresLbl.Location = new System.Drawing.Point(13, 253);
            this.dateExpiresLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateExpiresLbl.Name = "dateExpiresLbl";
            this.dateExpiresLbl.Size = new System.Drawing.Size(167, 17);
            this.dateExpiresLbl.TabIndex = 17;
            this.dateExpiresLbl.Text = "Дата истечения задачи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 16;
            // 
            // taskDescriptionRtb
            // 
            this.taskDescriptionRtb.Location = new System.Drawing.Point(13, 81);
            this.taskDescriptionRtb.Margin = new System.Windows.Forms.Padding(4);
            this.taskDescriptionRtb.Name = "taskDescriptionRtb";
            this.taskDescriptionRtb.Size = new System.Drawing.Size(481, 159);
            this.taskDescriptionRtb.TabIndex = 15;
            this.taskDescriptionRtb.Text = "";
            // 
            // taskDescriptionLbl
            // 
            this.taskDescriptionLbl.AutoSize = true;
            this.taskDescriptionLbl.Location = new System.Drawing.Point(13, 61);
            this.taskDescriptionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskDescriptionLbl.Name = "taskDescriptionLbl";
            this.taskDescriptionLbl.Size = new System.Drawing.Size(125, 17);
            this.taskDescriptionLbl.TabIndex = 14;
            this.taskDescriptionLbl.Text = "Описание задачи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Заголовок задачи";
            // 
            // taskTitleLbl
            // 
            this.taskTitleLbl.AutoSize = true;
            this.taskTitleLbl.Location = new System.Drawing.Point(10, 11);
            this.taskTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskTitleLbl.Name = "taskTitleLbl";
            this.taskTitleLbl.Size = new System.Drawing.Size(127, 17);
            this.taskTitleLbl.TabIndex = 13;
            this.taskTitleLbl.Text = "Заголовок задачи";
            // 
            // taskTitleTb
            // 
            this.taskTitleTb.Location = new System.Drawing.Point(13, 33);
            this.taskTitleTb.Margin = new System.Windows.Forms.Padding(4);
            this.taskTitleTb.Name = "taskTitleTb";
            this.taskTitleTb.Size = new System.Drawing.Size(481, 22);
            this.taskTitleTb.TabIndex = 11;
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 366);
            this.Controls.Add(this.taskTimeExpiredDTP);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.taskDateExpiredDTP);
            this.Controls.Add(this.updateTaskBtn);
            this.Controls.Add(this.dateExpiresLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskDescriptionRtb);
            this.Controls.Add(this.taskDescriptionLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskTitleLbl);
            this.Controls.Add(this.taskTitleTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditTaskForm";
            this.Text = "Редактирование задачи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker taskTimeExpiredDTP;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.DateTimePicker taskDateExpiredDTP;
        private System.Windows.Forms.Button updateTaskBtn;
        private System.Windows.Forms.Label dateExpiresLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox taskDescriptionRtb;
        private System.Windows.Forms.Label taskDescriptionLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label taskTitleLbl;
        private System.Windows.Forms.TextBox taskTitleTb;
    }
}