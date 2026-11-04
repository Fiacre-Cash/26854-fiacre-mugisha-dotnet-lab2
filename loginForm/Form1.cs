using System.Drawing.Text;

namespace loginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            MessageBox.Show("Username: " + username + "\nPassword: " + password);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTxt.Text) ||
                string.IsNullOrWhiteSpace(passwordTxt.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
                MessageBox.Show("Welcome,"+ usernameTxt.Text + "! Login successful.");


            MenuForm menuForm = new MenuForm(this);
            menuForm.Show();
            this.Hide();
        }
    }
}
