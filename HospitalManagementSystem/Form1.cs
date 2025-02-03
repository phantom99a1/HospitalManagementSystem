using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, System.EventArgs e)
        {
            if(txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                var main = new Main();
                main.Show();
            }
            else if(txtUsername.Text != "abcd" && txtPassword.Text != "1234"){
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
