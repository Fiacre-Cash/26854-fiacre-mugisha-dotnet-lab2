namespace loginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show("Please enter both username and password.", "Login");
                return;
            }
            MessageBox.Show("Login successful.", "Login");

            MenuForm menuForm = new MenuForm(this);
            menuForm.Show();
            this.Hide();
        }
    }
}
