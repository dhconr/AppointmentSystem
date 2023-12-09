namespace AppointmentSystem
{
    partial class AppointmentForm
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
            DaysContainer = new FlowLayoutPanel();
            SundayLabel = new Label();
            MondayLabel = new Label();
            TuesdayLabel = new Label();
            WednesdayLabel = new Label();
            ThursdayLabel = new Label();
            FridayLabel = new Label();
            SaturdayLabel = new Label();
            ViewChangeButton = new Button();
            AddAppointmentButton = new Button();
            SuspendLayout();
            // 
            // DaysContainer
            // 
            DaysContainer.Location = new Point(12, 76);
            DaysContainer.Name = "DaysContainer";
            DaysContainer.Size = new Size(1199, 647);
            DaysContainer.TabIndex = 0;
            // 
            // SundayLabel
            // 
            SundayLabel.AutoSize = true;
            SundayLabel.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            SundayLabel.Location = new Point(12, 26);
            SundayLabel.Name = "SundayLabel";
            SundayLabel.Size = new Size(124, 47);
            SundayLabel.TabIndex = 1;
            SundayLabel.Text = "Sunday";
            // 
            // MondayLabel
            // 
            MondayLabel.AutoSize = true;
            MondayLabel.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            MondayLabel.Location = new Point(186, 26);
            MondayLabel.Name = "MondayLabel";
            MondayLabel.Size = new Size(129, 47);
            MondayLabel.TabIndex = 2;
            MondayLabel.Text = "Monday";
            // 
            // TuesdayLabel
            // 
            TuesdayLabel.AutoSize = true;
            TuesdayLabel.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            TuesdayLabel.Location = new Point(357, 29);
            TuesdayLabel.Name = "TuesdayLabel";
            TuesdayLabel.Size = new Size(138, 47);
            TuesdayLabel.TabIndex = 3;
            TuesdayLabel.Text = "Tuesday";
            // 
            // WednesdayLabel
            // 
            WednesdayLabel.AutoSize = true;
            WednesdayLabel.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            WednesdayLabel.Location = new Point(528, 29);
            WednesdayLabel.Name = "WednesdayLabel";
            WednesdayLabel.Size = new Size(182, 47);
            WednesdayLabel.TabIndex = 4;
            WednesdayLabel.Text = "Wednesday";
            // 
            // ThursdayLabel
            // 
            ThursdayLabel.AutoSize = true;
            ThursdayLabel.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            ThursdayLabel.Location = new Point(699, 29);
            ThursdayLabel.Name = "ThursdayLabel";
            ThursdayLabel.Size = new Size(148, 47);
            ThursdayLabel.TabIndex = 5;
            ThursdayLabel.Text = "Thursday";
            // 
            // FridayLabel
            // 
            FridayLabel.AutoSize = true;
            FridayLabel.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            FridayLabel.Location = new Point(870, 29);
            FridayLabel.Name = "FridayLabel";
            FridayLabel.Size = new Size(105, 47);
            FridayLabel.TabIndex = 6;
            FridayLabel.Text = "Friday";
            // 
            // SaturdayLabel
            // 
            SaturdayLabel.AutoSize = true;
            SaturdayLabel.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            SaturdayLabel.Location = new Point(1041, 26);
            SaturdayLabel.Name = "SaturdayLabel";
            SaturdayLabel.Size = new Size(143, 47);
            SaturdayLabel.TabIndex = 7;
            SaturdayLabel.Text = "Saturday";
            // 
            // ViewChangeButton
            // 
            ViewChangeButton.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ViewChangeButton.Location = new Point(12, 744);
            ViewChangeButton.Name = "ViewChangeButton";
            ViewChangeButton.Size = new Size(155, 78);
            ViewChangeButton.TabIndex = 8;
            ViewChangeButton.Text = "Change view to Weekly";
            ViewChangeButton.UseVisualStyleBackColor = true;
            ViewChangeButton.Click += ViewChangeButton_Click;
            // 
            // AddAppointmentButton
            // 
            AddAppointmentButton.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddAppointmentButton.Location = new Point(1056, 744);
            AddAppointmentButton.Name = "AddAppointmentButton";
            AddAppointmentButton.Size = new Size(155, 78);
            AddAppointmentButton.TabIndex = 9;
            AddAppointmentButton.Text = "Add Appointment";
            AddAppointmentButton.UseVisualStyleBackColor = true;
            AddAppointmentButton.Click += AddAppointmentButton_Click;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1228, 834);
            Controls.Add(AddAppointmentButton);
            Controls.Add(ViewChangeButton);
            Controls.Add(SaturdayLabel);
            Controls.Add(FridayLabel);
            Controls.Add(ThursdayLabel);
            Controls.Add(WednesdayLabel);
            Controls.Add(TuesdayLabel);
            Controls.Add(MondayLabel);
            Controls.Add(SundayLabel);
            Controls.Add(DaysContainer);
            Name = "AppointmentForm";
            Text = "Appointment Form";
            Load += AppointmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel DaysContainer;
        private Label SundayLabel;
        private Label MondayLabel;
        private Label TuesdayLabel;
        private Label WednesdayLabel;
        private Label ThursdayLabel;
        private Label FridayLabel;
        private Label SaturdayLabel;
        private Button ViewChangeButton;
        private Button AddAppointmentButton;
    }
}