namespace AppointmentSystem;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }


    private void LogInBtn_Click(object sender, System.EventArgs e)
    {
        Hide();
        var appointmentForm = new AppointmentForm();
        appointmentForm.Show();
    }
}