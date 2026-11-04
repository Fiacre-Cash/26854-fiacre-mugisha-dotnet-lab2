using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace loginForm
{
    public partial class MenuForm : Form
    {
        private readonly Form1 loginForm;

        public MenuForm(Form1 loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void bicycleBtn_Click(object sender, EventArgs e)
        {
            BicycleForm bicycle = new BicycleForm(this, loginForm);
            bicycle.Show();
            this.Hide();
        }

        private void mushroomBtn_Click(object sender, EventArgs e)
        {
            MushroomForm mushroom = new MushroomForm(this, loginForm);
            mushroom.Show();
            this.Hide();
        }
    }
}
