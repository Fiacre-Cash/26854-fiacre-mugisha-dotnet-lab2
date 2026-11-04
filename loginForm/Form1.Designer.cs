namespace loginForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            closeBtn = new Button();
            loginBtn = new Button();
            label1 = new Label();
            password = new Label();
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            SuspendLayout();
            // 
            // closeBtn
            // 
            closeBtn.BackColor = SystemColors.ButtonShadow;
            closeBtn.Location = new Point(179, 194);
            closeBtn.Margin = new Padding(3, 2, 3, 2);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(119, 42);
            closeBtn.TabIndex = 0;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.ButtonShadow;
            loginBtn.Location = new Point(361, 194);
            loginBtn.Margin = new Padding(3, 2, 3, 2);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(114, 42);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 56);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(159, 125);
            password.Name = "password";
            password.Size = new Size(63, 15);
            password.TabIndex = 4;
            password.Text = "Password";
            // 
            // usernameTxt
            // 
            usernameTxt.BackColor = SystemColors.ButtonShadow;
            usernameTxt.Location = new Point(274, 50);
            usernameTxt.Margin = new Padding(3, 2, 3, 2);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(201, 21);
            usernameTxt.TabIndex = 5;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = SystemColors.ButtonShadow;
            passwordTxt.Location = new Point(274, 119);
            passwordTxt.Margin = new Padding(3, 2, 3, 2);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(201, 21);
            passwordTxt.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(771, 402);
            Controls.Add(passwordTxt);
            Controls.Add(usernameTxt);
            Controls.Add(password);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(closeBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeBtn;
        private Button loginBtn;
        private Label label1;
        private Label password;
        private TextBox usernameTxt;
        private TextBox passwordTxt;
    }
}
