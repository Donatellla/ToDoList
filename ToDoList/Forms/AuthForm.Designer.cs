namespace ToDoList.Forms
{
    partial class AuthForm
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
            this.resultLbl = new System.Windows.Forms.Label();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.authBtn = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(13, 181);
            this.resultLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 16);
            this.resultLbl.TabIndex = 19;
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(13, 144);
            this.addUserBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(328, 28);
            this.addUserBtn.TabIndex = 18;
            this.addUserBtn.Text = "Добавить пользователя";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // authBtn
            // 
            this.authBtn.Location = new System.Drawing.Point(13, 109);
            this.authBtn.Margin = new System.Windows.Forms.Padding(4);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(328, 28);
            this.authBtn.TabIndex = 17;
            this.authBtn.Text = "Авторизация";
            this.authBtn.UseVisualStyleBackColor = true;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(13, 57);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(56, 16);
            this.passwordLbl.TabIndex = 16;
            this.passwordLbl.Text = "Пароль";
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(13, 77);
            this.passwordTb.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(327, 22);
            this.passwordTb.TabIndex = 15;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(13, 9);
            this.loginLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(46, 16);
            this.loginLbl.TabIndex = 14;
            this.loginLbl.Text = "Логин";
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(13, 29);
            this.loginTb.Margin = new System.Windows.Forms.Padding(4);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(327, 22);
            this.loginTb.TabIndex = 13;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(354, 211);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.authBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.loginTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox loginTb;
    }
}