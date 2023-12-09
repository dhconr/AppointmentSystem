using System.Device.Location;
using GeoCoordinatePortable; 

namespace AppointmentSystem;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        //GeoCoordinatePortable.GeoPosition<GeoCoordinatePortable.GeoCoordinate> position = new();
        ////geoCoordinateWatcher.TryStart(false, TimeSpan.FromMilliseconds(1000));
        ////var position = geoCoordinateWatcher.Position;
        //if (position.Location.IsUnknown)
        //{
        //    MessageBox.Show("Location is unknown");
        //}
        //else
        //{
        //    var latitude = position.Location.Latitude;
        //    var longitude = position.Location.Longitude;
        //    MessageBox.Show($"Latitude: {latitude}, Longitude: {longitude}");
        //}
    }


    private void LogInBtn_Click(object sender, System.EventArgs e)
    {
        LoginForm_Load(sender, e);
        Hide();
        var appointmentForm = new AppointmentForm();
        appointmentForm.Show();
    }
}