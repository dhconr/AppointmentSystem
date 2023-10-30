namespace AppointmentSystem
{
    partial class LoginForm
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
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            LogInBtn = new Button();
            SuspendLayout();
            // 
            // usernameInput
            // 
            usernameInput.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            usernameInput.Location = new Point(167, 99);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(210, 47);
            usernameInput.TabIndex = 0;
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            passwordInput.Location = new Point(167, 249);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(210, 47);
            passwordInput.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(167, 38);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(142, 39);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(167, 184);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(137, 39);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // LogInBtn
            // 
            LogInBtn.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            LogInBtn.Location = new Point(167, 419);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(220, 58);
            LogInBtn.TabIndex = 4;
            LogInBtn.Text = "Log In";
            LogInBtn.UseVisualStyleBackColor = true;
            LogInBtn.Click += LogInBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 523);
            Controls.Add(LogInBtn);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameInput;
        private TextBox passwordInput;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button LogInBtn;
    }
}