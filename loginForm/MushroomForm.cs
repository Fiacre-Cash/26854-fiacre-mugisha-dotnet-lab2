using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace loginForm
{
    public partial class MushroomForm : Form
    {
        private readonly MenuForm menuForm;
        private readonly Form1 loginForm;

        public MushroomForm(MenuForm menuForm,Form1 loginForm)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            this.loginForm = loginForm;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            menuForm.Show();
            this.Hide();
        }

        private void revealMushroomBtn_Click(object sender, EventArgs e)
        {
            /*
              Console.Write("Does your mushroom grow in a forest? (yes/no): ");
            growsInForest = Console.ReadLine().ToLower() == "yes";

           
            Console.Write("Does your mushroom have a convex cup? (yes/no): ");
            hasConvexCup = Console.ReadLine().ToLower() == "yes";

            if (growsInForest && hasConvexCup)
            {
               

                Console.Write("Does your mushroom have a ring? (yes/no): ");
                hasRing = Console.ReadLine().ToLower() == "yes";

                if (hasRing)
                {
                    Console.WriteLine("Your mushroom is Amanite tue-mouche.");
                }
                else
                {
                    Console.WriteLine("Your mushroom is Pied bleu.");
                }
            }
            else if (growsInForest && !hasConvexCup)
            {
                
                Console.Write("Does your mushroom have gills? (yes/no): ");
                hasGills = Console.ReadLine().ToLower() == "yes";

                if (hasGills)
                {
                    Console.WriteLine("Your mushroom is Girolle.");
                }
                else
                {
                    Console.WriteLine("Your mushroom is Cepe de Bordeaux.");
                }
            }


            
            else if (!growsInForest && hasConvexCup)
            {
               
                Console.WriteLine("Your mushroom is Agaric Jaunissant.");
            }
            else
            {
                Console.WriteLine("Your mushroom is Coprin Chevelu.");
            }
        }

             */
            if ((!yesForest.Checked && !noForest.Checked) ||
                (!yesConvex.Checked && !noConvex.Checked))
            {
                MessageBox.Show("Please answer the forest and convex cup questions.");
                return;
            }

            if (yesForest.Checked && yesConvex.Checked &&
                !yesRing.Checked && !noRing.Checked)
            {
                MessageBox.Show("Please answer the ring question.");
                return;
            }

            if (yesForest.Checked && noConvex.Checked &&
                !yesGills.Checked && !noGills.Checked)
            {
                MessageBox.Show("Please answer the gills question.");
                return;
            }

            if (yesForest.Checked && yesConvex.Checked)
            {
                if (yesRing.Checked)
                {
                    MessageBox.Show("Your mushroom is Amanite tue-mouche.");
                }
                else
                {
                    MessageBox.Show("Your mushroom is Pied bleu.");
                }
            }
            else if (yesForest.Checked && noConvex.Checked)
            {
                if (yesGills.Checked)
                {
                    MessageBox.Show("Your mushroom is Girolle.");
                }
                else
                {
                    MessageBox.Show("Your mushroom is Cepe de Bordeaux.");
                }
            }
            else if (noForest.Checked && yesConvex.Checked)
            {
                MessageBox.Show("Your mushroom is Agaric Jaunissant.");
            }
            else
            {
                MessageBox.Show("Your mushroom is Coprin Chevelu.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Hide();
        }

        private void MushroomForm_Load(object sender, EventArgs e)
        {

        }
    }
}
