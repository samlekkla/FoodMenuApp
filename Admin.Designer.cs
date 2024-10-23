namespace GrupparbeteFoodapplication
{
    partial class Admin
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
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(229, 120);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(229, 31);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(229, 210);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(229, 31);
            textBoxPassword.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(229, 92);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(91, 25);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(233, 182);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(87, 25);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(291, 294);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(112, 34);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Log in";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 450);
            Controls.Add(buttonLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelUsername;
        private Label labelPassword;
        private Button buttonLogin;
    }
}