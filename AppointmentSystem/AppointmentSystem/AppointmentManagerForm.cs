using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace AppointmentSystem
{
    public partial class AppointmentManagerForm : Form
    {
        public AppointmentManagerForm()
        {
            InitializeComponent();
        }

        private void AppointmentCancelButton_Click(object sender, EventArgs e)
        {
            try
            { 
                //string connectionString = "SERVER=localhost;PORT=3306;UID=root;PASSWORD=%9779_ConroD*%";
                //SqlConnectionStringBuilder builder = new();
                //builder.DataSource = "localhost";
                //builder.InitialCatalog = "appointment_system_wgu";
                //builder.UserID = "test";
                //builder.Password = "test";

                var command = "SELECT * FROM appointment";

                string con = "Data Source = localhost; Initial Catalog = appointment_system_wgu; User ID = root; Password = %9779_ConroD*%";

                using MySql.Data.MySqlClient.MySqlConnection connection = new(con);

                using MySql.Data.MySqlClient.MySqlCommand sqlCommand  = new(command, connection);

                connection.Open();

                using MySql.Data.MySqlClient.MySqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    var appointmentId = reader.GetInt32(0);
                    var customerId = reader.GetInt32(1);
                    var userId = reader.GetInt32(2);
                    var title = reader.GetString(3);
                    var description = reader.GetString(4);
                    var location = reader.GetString(5);
                    var contact = reader.GetString(6);
                    var type = reader.GetString(7);
                    var url = reader.GetString(8);
                    var start = reader.GetDateTime(9);
                    var end = reader.GetDateTime(10);
                    var createDate = reader.GetDateTime(11);
                    var createdBy = reader.GetString(12);
                    var lastUpdate = reader.GetDateTime(13);
                    var lastUpdateBy = reader.GetString(14);

                    //MessageBox.Show("appointmentID: {0}, customerID: {1}, userID: {2}, title: {3}, description: {4}, location: {5}, contact: {6}, type: {7}, url: {8}, start: {9}, end: {10}, createDate: {11}, createdBy: {12}, lastUpdate: {13}, lastUpdateBy: {14}", appointmentId, customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy);

                    // finish the following line with all the variables
                    MessageBox.Show($"appointmentID: {appointmentId}, customerID: {customerId}, userID: {userId}, title: {title}, description: {description} ");

                    //var appointment = new Appointment(appointmentId, customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy);

                    //if (appointment.AppointmentId == int.Parse(AppointmentIdTextBox.Text))
                    //{
                    //    var deleteCommand = $"DELETE FROM appointments WHERE appointmentId = {appointment.AppointmentId}";

                    //    using SqlCommand deleteSqlCommand = new(deleteCommand, connection);

                    //    deleteSqlCommand.ExecuteNonQuery();

                    //    MessageBox.Show("Appointment deleted");
                    //}
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
