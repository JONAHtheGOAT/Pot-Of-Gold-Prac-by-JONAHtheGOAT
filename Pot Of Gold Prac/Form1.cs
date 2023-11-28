using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pot_Of_Gold_Prac
{
    public partial class FormDoors : Form
    {

        public static int score = 0;


        public static void EndGame()
        {
         

            MessageBox.Show("The gold is not here!");
            MessageBox.Show("You went through " + score.ToString() + " doors",
            "Doors Entered");
            Application.Exit();
        }
            public FormDoors()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Door2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (GreenDoor.Checked)
            {
                MessageBox.Show("YOU FOUND THE GOLD");

                score = score + 1;
                this.Hide();
                Form2 greenDoor = new Form2();
                greenDoor.Show();
            }
            if (BlueDoor.Checked)
            {
                MessageBox.Show("YOU DID NOT FIND THE GOLD");
                score = score + 1;
                this.Hide();
                Form3 blueDoor = new Form3();
                blueDoor.Show();
            }
            if (checkBox2.Checked)
            {
                MessageBox.Show("YOU DID NOT FIND THE GOLD");
                score = score + 1;
                this.Hide();
                Form3 blueDoor = new Form3();
                blueDoor.Show();
            }

        }
    }
}
