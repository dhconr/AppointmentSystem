using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum View
{
    Weekly,
    Monthly
}

namespace AppointmentSystem
{
    public partial class AppointmentForm : Form
    {
        private View view = View.Monthly;

        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            DisplayDaysMonthly();
        }

        private void DisplayDaysMonthly()
        {
            DateTime now = DateTime.Now;

            DateTime startOfTheMonth = new DateTime(now.Year, now.Month, 1);

            var days = DateTime.DaysInMonth(now.Year, now.Month);
            var daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            for (var i = 0; i < daysOfTheWeek; i++)
            {
                UserControlBlank userControlBlank = new();
                DaysContainer.Controls.Add(userControlBlank);
            }

            for (var i = 1; i < days + 1; i++)
            {
                UserControlDays userControlDays = new();
                userControlDays.days(i);
                DaysContainer.Controls.Add(userControlDays);
            }
        }

        private void DisplayDaysWeekly()
        {
            DateTime now = DateTime.Now;

            // Find the start of the week (assuming Sunday as the first day of the week)
            int daysUntilWeekStart = (int)now.DayOfWeek;
            DateTime startOfWeek = now.AddDays(-daysUntilWeekStart);

            // Loop through the 7 days of the week
            for (int i = 0; i < 7; i++)
            {
                // Calculate the date for the current day of the week
                DateTime dayOfWeek = startOfWeek.AddDays(i);

                // Create and configure the UserControl for this day
                UserControlWeekly userControlWeekly = new();
                userControlWeekly.days(dayOfWeek.Day); // Set the day number (you might need to adjust this method to accept DateTime or modify accordingly)

                // Add the control to your container
                DaysContainer.Controls.Add(userControlWeekly);
            }
        }

        private void ViewChangeButton_Click(object sender, EventArgs e)
        {
            DaysContainer.Controls.Clear();

            if (view == View.Monthly)
            {
                DisplayDaysWeekly();
                view = View.Weekly;
                ViewChangeButton.Text = "Change view to Monthly";
            }
            else
            {
                DisplayDaysMonthly();
                view = View.Monthly;
                ViewChangeButton.Text = "Change view to Weekly";
            }
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            AppointmentManagerForm appointmentManagerForm = new();
            appointmentManagerForm.ShowDialog();
        }
    }
}
