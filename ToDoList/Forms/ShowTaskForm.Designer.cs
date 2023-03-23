namespace ToDoList.Forms
{
    partial class ShowTaskForm
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
            this.dateExpiresLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taskDescriptionRtb = new System.Windows.Forms.RichTextBox();
            this.taskDescriptionLbl = new System.Windows.Forms.Label();
            this.taskTitleLbl = new System.Windows.Forms.Label();
            this.taskTitleTb = new System.Windows.Forms.TextBox();
            this.taskTimeAddDTP = new System.Windows.Forms.DateTimePicker();
            this.taskDateAddDTP = new System.Windows.Forms.DateTimePicker();
            this.dateAddLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taskTimeCloseDTP = new System.Windows.Forms.DateTimePicker();
            this.taskDateCloseDTP = new System.Windows.Forms.DateTimePicker();
            this.dateCloseLbl = new System.Windows.Forms.Label();
            this.taskStatusLbl = new System.Windows.Forms.Label();
            this.taskStatusTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // taskTimeExpiredDTP
            // 
            this.taskTimeExpiredDTP.Enabled = false;
            this.taskTimeExpiredDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.taskTimeExpiredDTP.Location = new System.Drawing.Point(267, 261);
            this.taskTimeExpiredDTP.Name = "taskTimeExpiredDTP";
            this.taskTimeExpiredDTP.ShowUpDown = true;
            this.taskTimeExpiredDTP.Size = new System.Drawing.Size(102, 20);
            this.taskTimeExpiredDTP.TabIndex = 20;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(10, 378);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(10, 13);
            this.resultLbl.TabIndex = 19;
            this.resultLbl.Text = " ";
            // 
            // taskDateExpiredDTP
            // 
            this.taskDateExpiredDTP.Enabled = false;
            this.taskDateExpiredDTP.Location = new System.Drawing.Point(8, 261);
            this.taskDateExpiredDTP.Name = "taskDateExpiredDTP";
            this.taskDateExpiredDTP.Size = new System.Drawing.Size(254, 20);
            this.taskDateExpiredDTP.TabIndex = 18;
            // 
            // dateExpiresLbl
            // 
            this.dateExpiresLbl.AutoSize = true;
            this.dateExpiresLbl.Location = new System.Drawing.Point(7, 243);
            this.dateExpiresLbl.Name = "dateExpiresLbl";
            this.dateExpiresLbl.Size = new System.Drawing.Size(126, 13);
            this.dateExpiresLbl.TabIndex = 16;
            this.dateExpiresLbl.Text = "Дата истечения задачи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // taskDescriptionRtb
            // 
            this.taskDescriptionRtb.Location = new System.Drawing.Point(7, 67);
            this.taskDescriptionRtb.Name = "taskDescriptionRtb";
            this.taskDescriptionRtb.ReadOnly = true;
            this.taskDescriptionRtb.Size = new System.Drawing.Size(362, 130);
            this.taskDescriptionRtb.TabIndex = 14;
            this.taskDescriptionRtb.Text = "";
            // 
            // taskDescriptionLbl
            // 
            this.taskDescriptionLbl.AutoSize = true;
            this.taskDescriptionLbl.Location = new System.Drawing.Point(7, 50);
            this.taskDescriptionLbl.Name = "taskDescriptionLbl";
            this.taskDescriptionLbl.Size = new System.Drawing.Size(95, 13);
            this.taskDescriptionLbl.TabIndex = 13;
            this.taskDescriptionLbl.Text = "Описание задачи";
            // 
            // taskTitleLbl
            // 
            this.taskTitleLbl.AutoSize = true;
            this.taskTitleLbl.Location = new System.Drawing.Point(7, 11);
            this.taskTitleLbl.Name = "taskTitleLbl";
            this.taskTitleLbl.Size = new System.Drawing.Size(99, 13);
            this.taskTitleLbl.TabIndex = 12;
            this.taskTitleLbl.Text = "Заголовок задачи";
            // 
            // taskTitleTb
            // 
            this.taskTitleTb.Location = new System.Drawing.Point(7, 28);
            this.taskTitleTb.Name = "taskTitleTb";
            this.taskTitleTb.ReadOnly = true;
            this.taskTitleTb.Size = new System.Drawing.Size(362, 20);
            this.taskTitleTb.TabIndex = 11;
            // 
            // taskTimeAddDTP
            // 
            this.taskTimeAddDTP.Enabled = false;
            this.taskTimeAddDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.taskTimeAddDTP.Location = new System.Drawing.Point(266, 222);
            this.taskTimeAddDTP.Name = "taskTimeAddDTP";
            this.taskTimeAddDTP.ShowUpDown = true;
            this.taskTimeAddDTP.Size = new System.Drawing.Size(102, 20);
            this.taskTimeAddDTP.TabIndex = 24;
            // 
            // taskDateAddDTP
            // 
            this.taskDateAddDTP.Enabled = false;
            this.taskDateAddDTP.Location = new System.Drawing.Point(7, 222);
            this.taskDateAddDTP.Name = "taskDateAddDTP";
            this.taskDateAddDTP.Size = new System.Drawing.Size(254, 20);
            this.taskDateAddDTP.TabIndex = 23;
            // 
            // dateAddLbl
            // 
            this.dateAddLbl.AutoSize = true;
            this.dateAddLbl.Location = new System.Drawing.Point(7, 206);
            this.dateAddLbl.Name = "dateAddLbl";
            this.dateAddLbl.Size = new System.Drawing.Size(122, 13);
            this.dateAddLbl.TabIndex = 22;
            this.dateAddLbl.Text = "Дата создания задачи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 21;
            // 
            // taskTimeCloseDTP
            // 
            this.taskTimeCloseDTP.Enabled = false;
            this.taskTimeCloseDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.taskTimeCloseDTP.Location = new System.Drawing.Point(267, 304);
            this.taskTimeCloseDTP.Name = "taskTimeCloseDTP";
            this.taskTimeCloseDTP.ShowUpDown = true;
            this.taskTimeCloseDTP.Size = new System.Drawing.Size(102, 20);
            this.taskTimeCloseDTP.TabIndex = 27;
            // 
            // taskDateCloseDTP
            // 
            this.taskDateCloseDTP.Enabled = false;
            this.taskDateCloseDTP.Location = new System.Drawing.Point(8, 304);
            this.taskDateCloseDTP.Name = "taskDateCloseDTP";
            this.taskDateCloseDTP.Size = new System.Drawing.Size(254, 20);
            this.taskDateCloseDTP.TabIndex = 26;
            // 
            // dateCloseLbl
            // 
            this.dateCloseLbl.AutoSize = true;
            this.dateCloseLbl.Location = new System.Drawing.Point(7, 288);
            this.dateCloseLbl.Name = "dateCloseLbl";
            this.dateCloseLbl.Size = new System.Drawing.Size(123, 13);
            this.dateCloseLbl.TabIndex = 25;
            this.dateCloseLbl.Text = "Дата закрытия задачи";
            // 
            // taskStatusLbl
            // 
            this.taskStatusLbl.AutoSize = true;
            this.taskStatusLbl.Location = new System.Drawing.Point(5, 333);
            this.taskStatusLbl.Name = "taskStatusLbl";
            this.taskStatusLbl.Size = new System.Drawing.Size(79, 13);
            this.taskStatusLbl.TabIndex = 29;
            this.taskStatusLbl.Text = "Статус задачи";
            // 
            // taskStatusTb
            // 
            this.taskStatusTb.Location = new System.Drawing.Point(8, 349);
            this.taskStatusTb.Name = "taskStatusTb";
            this.taskStatusTb.ReadOnly = true;
            this.taskStatusTb.Size = new System.Drawing.Size(362, 20);
            this.taskStatusTb.TabIndex = 28;
            // 
            // ShowTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 402);
            this.Controls.Add(this.taskStatusLbl);
            this.Controls.Add(this.taskStatusTb);
            this.Controls.Add(this.taskTimeCloseDTP);
            this.Controls.Add(this.taskDateCloseDTP);
            this.Controls.Add(this.dateCloseLbl);
            this.Controls.Add(this.taskTimeAddDTP);
            this.Controls.Add(this.taskDateAddDTP);
            this.Controls.Add(this.dateAddLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taskTimeExpiredDTP);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.taskDateExpiredDTP);
            this.Controls.Add(this.dateExpiresLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskDescriptionRtb);
            this.Controls.Add(this.taskDescriptionLbl);
            this.Controls.Add(this.taskTitleLbl);
            this.Controls.Add(this.taskTitleTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ShowTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр задачи";
            this.Load += new System.EventHandler(this.ShowTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker taskTimeExpiredDTP;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.DateTimePicker taskDateExpiredDTP;
        private System.Windows.Forms.Label dateExpiresLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox taskDescriptionRtb;
        private System.Windows.Forms.Label taskDescriptionLbl;
        private System.Windows.Forms.Label taskTitleLbl;
        private System.Windows.Forms.TextBox taskTitleTb;
        private System.Windows.Forms.DateTimePicker taskTimeAddDTP;
        private System.Windows.Forms.DateTimePicker taskDateAddDTP;
        private System.Windows.Forms.Label dateAddLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker taskTimeCloseDTP;
        private System.Windows.Forms.DateTimePicker taskDateCloseDTP;
        private System.Windows.Forms.Label dateCloseLbl;
        private System.Windows.Forms.Label taskStatusLbl;
        private System.Windows.Forms.TextBox taskStatusTb;
    }
}