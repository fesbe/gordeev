namespace kursach_2._0
{
    partial class LoginForm
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
            this.LoginTitlePanel = new System.Windows.Forms.Panel();
            this.ClosePB = new System.Windows.Forms.PictureBox();
            this.TitkeLabel = new System.Windows.Forms.Label();
            this.LoginCenterMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginCenterPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.LoginTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePB)).BeginInit();
            this.LoginCenterMetroPanel.SuspendLayout();
            this.LoginCenterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTitlePanel
            // 
            this.LoginTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.LoginTitlePanel.Controls.Add(this.ClosePB);
            this.LoginTitlePanel.Controls.Add(this.TitkeLabel);
            this.LoginTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.LoginTitlePanel.Name = "LoginTitlePanel";
            this.LoginTitlePanel.Size = new System.Drawing.Size(290, 32);
            this.LoginTitlePanel.TabIndex = 0;
            // 
            // ClosePB
            // 
            this.ClosePB.Image = global::kursach_2._0.Properties.Resources.close;
            this.ClosePB.Location = new System.Drawing.Point(258, 0);
            this.ClosePB.Name = "ClosePB";
            this.ClosePB.Size = new System.Drawing.Size(32, 32);
            this.ClosePB.TabIndex = 5;
            this.ClosePB.TabStop = false;
            this.ClosePB.Click += new System.EventHandler(this.ClosePB_Click);
            // 
            // TitkeLabel
            // 
            this.TitkeLabel.AutoSize = true;
            this.TitkeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitkeLabel.ForeColor = System.Drawing.Color.White;
            this.TitkeLabel.Location = new System.Drawing.Point(111, 3);
            this.TitkeLabel.Name = "TitkeLabel";
            this.TitkeLabel.Size = new System.Drawing.Size(66, 25);
            this.TitkeLabel.TabIndex = 4;
            this.TitkeLabel.Text = "Логин";
            // 
            // LoginCenterMetroPanel
            // 
            this.LoginCenterMetroPanel.Controls.Add(this.LoginBTN);
            this.LoginCenterMetroPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginCenterMetroPanel.HorizontalScrollbarBarColor = true;
            this.LoginCenterMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.LoginCenterMetroPanel.HorizontalScrollbarSize = 10;
            this.LoginCenterMetroPanel.Location = new System.Drawing.Point(0, 260);
            this.LoginCenterMetroPanel.Name = "LoginCenterMetroPanel";
            this.LoginCenterMetroPanel.Size = new System.Drawing.Size(290, 50);
            this.LoginCenterMetroPanel.TabIndex = 1;
            this.LoginCenterMetroPanel.VerticalScrollbarBarColor = true;
            this.LoginCenterMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.LoginCenterMetroPanel.VerticalScrollbarSize = 10;
            // 
            // LoginBTN
            // 
            this.LoginBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBTN.Location = new System.Drawing.Point(95, 5);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(100, 40);
            this.LoginBTN.TabIndex = 2;
            this.LoginBTN.Text = "Войти";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(12, 22);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(66, 25);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(12, 71);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(79, 25);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LoginCenterPanel
            // 
            this.LoginCenterPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginCenterPanel.Controls.Add(this.ErrorLabel);
            this.LoginCenterPanel.Controls.Add(this.PasswordTB);
            this.LoginCenterPanel.Controls.Add(this.LoginTB);
            this.LoginCenterPanel.Controls.Add(this.PasswordLabel);
            this.LoginCenterPanel.Controls.Add(this.LoginLabel);
            this.LoginCenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginCenterPanel.Location = new System.Drawing.Point(0, 32);
            this.LoginCenterPanel.Name = "LoginCenterPanel";
            this.LoginCenterPanel.Size = new System.Drawing.Size(290, 228);
            this.LoginCenterPanel.TabIndex = 2;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(0, 104);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(290, 124);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTB.Location = new System.Drawing.Point(128, 68);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(150, 33);
            this.PasswordTB.TabIndex = 5;
            // 
            // LoginTB
            // 
            this.LoginTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTB.Location = new System.Drawing.Point(128, 19);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(150, 33);
            this.LoginTB.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 310);
            this.ControlBox = false;
            this.Controls.Add(this.LoginCenterPanel);
            this.Controls.Add(this.LoginCenterMetroPanel);
            this.Controls.Add(this.LoginTitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.LoginTitlePanel.ResumeLayout(false);
            this.LoginTitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePB)).EndInit();
            this.LoginCenterMetroPanel.ResumeLayout(false);
            this.LoginCenterPanel.ResumeLayout(false);
            this.LoginCenterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginTitlePanel;
        private MetroFramework.Controls.MetroPanel LoginCenterMetroPanel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label TitkeLabel;
        private System.Windows.Forms.PictureBox ClosePB;
        private System.Windows.Forms.Panel LoginCenterPanel;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button LoginBTN;
    }
}

