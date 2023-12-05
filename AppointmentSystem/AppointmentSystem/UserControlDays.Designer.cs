namespace AppointmentSystem
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UCDaysLabel = new Label();
            SuspendLayout();
            // 
            // UCDaysLabel
            // 
            UCDaysLabel.AutoSize = true;
            UCDaysLabel.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            UCDaysLabel.Location = new Point(23, 15);
            UCDaysLabel.Name = "UCDaysLabel";
            UCDaysLabel.Size = new Size(43, 37);
            UCDaysLabel.TabIndex = 0;
            UCDaysLabel.Text = "00";
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(UCDaysLabel);
            Name = "UserControlDays";
            Size = new Size(165, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UCDaysLabel;
    }
}
