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
    public partial class UserControlWeekly : UserControl
    {
        public UserControlWeekly()
        {
            InitializeComponent();
        }

        public void days(int dayNumber)
        {
            UCWeeklyLabel.Text = dayNumber + "";
        }
    }
}
