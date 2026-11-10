using System;
using System.Windows.Forms;

namespace loginForm
{
    public partial class BicycleForm : Form
    {
        private readonly MenuForm menuForm;
        private readonly Form1 loginForm;

        public BicycleForm(MenuForm menuForm, Form1 loginForm)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            this.loginForm = loginForm;
        }

        private void calculateRentBtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(startTimeTxt.Text) ||
                string.IsNullOrWhiteSpace(endTimeTxt.Text))
            {
                MessageBox.Show("Please enter both starting and ending times.");
                return;
            }

            
            if (!int.TryParse(startTimeTxt.Text.Trim(), out int startingTime) ||
                !int.TryParse(endTimeTxt.Text.Trim(), out int endingTime))
            {
                MessageBox.Show("Please enter whole numbers for the starting and ending times.");
                return;
            }

            
            if (startingTime < 0 || startingTime > 23)
            {
                MessageBox.Show("Invalid starting time. Enter a value between 0 and 23.");
                return;
            }

            
            if (endingTime < 1 || endingTime > 24)
            {
                MessageBox.Show("Invalid ending time. Enter a value between 1 and 24.");
                return;
            }

            
            if (endingTime <= startingTime)
            {
                MessageBox.Show("Ending time must be greater than starting time.");
                return;
            }

            
            int rentAmount = 0;

            for (int hour = startingTime; hour < endingTime; hour++)
            {
                if (hour < 7 || hour >= 21)
                {
                    rentAmount += 500;
                }
                else if (hour < 14 || hour >= 19)
                {
                    rentAmount += 1000;
                }
                else
                {
                    rentAmount += 1500;
                }
            }

            textBox1.Text = rentAmount + " RWF";
            MessageBox.Show("The total rent amount is: " + rentAmount + "RWF");
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            menuForm.Show();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Hide();
        }
    }
}