namespace AppointmentSystem
{
    partial class AppointmentManagerForm
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
            usernameInput = new TextBox();
            AppointmentLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            LogInBtn = new Button();
            AppointmentCancelButtonn = new Button();
            SuspendLayout();
            // 
            // usernameInput
            // 
            usernameInput.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            usernameInput.Location = new Point(276, 90);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(210, 47);
            usernameInput.TabIndex = 1;
            // 
            // AppointmentLabel
            // 
            AppointmentLabel.AutoSize = true;
            AppointmentLabel.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            AppointmentLabel.Location = new Point(12, 9);
            AppointmentLabel.Name = "AppointmentLabel";
            AppointmentLabel.Size = new Size(221, 39);
            AppointmentLabel.TabIndex = 3;
            AppointmentLabel.Text = "Add Appointment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 167);
            label1.Name = "label1";
            label1.Size = new Size(258, 39);
            label1.TabIndex = 4;
            label1.Text = "Type of appointment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(69, 39);
            label2.TabIndex = 5;
            label2.Text = "Title";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(276, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 47);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 248);
            label3.Name = "label3";
            label3.Size = new Size(154, 39);
            label3.TabIndex = 7;
            label3.Text = "Description";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 299);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(852, 193);
            textBox2.TabIndex = 8;
            // 
            // LogInBtn
            // 
            LogInBtn.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            LogInBtn.Location = new Point(644, 590);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(220, 58);
            LogInBtn.TabIndex = 9;
            LogInBtn.Text = "Add";
            LogInBtn.UseVisualStyleBackColor = true;
            // 
            // AppointmentCancelButtonn
            // 
            AppointmentCancelButtonn.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            AppointmentCancelButtonn.Location = new Point(392, 590);
            AppointmentCancelButtonn.Name = "AppointmentCancelButtonn";
            AppointmentCancelButtonn.Size = new Size(220, 58);
            AppointmentCancelButtonn.TabIndex = 10;
            AppointmentCancelButtonn.Text = "Cancel";
            AppointmentCancelButtonn.UseVisualStyleBackColor = true;
            // 
            // AppointmentManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 671);
            Controls.Add(AppointmentCancelButtonn);
            Controls.Add(LogInBtn);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AppointmentLabel);
            Controls.Add(usernameInput);
            Name = "AppointmentManagerForm";
            Text = "AppointmentManagerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameInput;
        private Label AppointmentLabel;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button LogInBtn;
        private Button AppointmentCancelButtonn;
    }
}