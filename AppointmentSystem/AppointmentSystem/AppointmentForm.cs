using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentSystem
{
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void DisplayDays()
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
    }
}
