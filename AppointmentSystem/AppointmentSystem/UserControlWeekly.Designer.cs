namespace AppointmentSystem
{
    partial class UserControlWeekly
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
            UCWeeklyLabel = new Label();
            SuspendLayout();
            // 
            // UCWeeklyLabel
            // 
            UCWeeklyLabel.AutoSize = true;
            UCWeeklyLabel.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            UCWeeklyLabel.Location = new Point(12, 17);
            UCWeeklyLabel.Name = "UCWeeklyLabel";
            UCWeeklyLabel.Size = new Size(43, 37);
            UCWeeklyLabel.TabIndex = 1;
            UCWeeklyLabel.Text = "00";
            // 
            // UserControlWeekly
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(UCWeeklyLabel);
            Name = "UserControlWeekly";
            Size = new Size(165, 644);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UCWeeklyLabel;
    }
}
