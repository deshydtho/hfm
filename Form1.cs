using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myren_Sutton_M5P11
{
    public partial class Form1 : Form
    {

        public static int genNum()
        {

        }

        public Form1()
        {
            InitializeComponent();
            returnRanNUM();
        }

        private int returnRanNUM()
        {
            Random rand = new Random();
            int ranNUM = rand.Next(1, 101);
            return ranNUM;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess=110;
            int ranNUM=0;


            while (ranNUM != guess)
            {
                MessageBox.Show(ranNUM.ToString());


                if (int.TryParse(g_tb.Text, out guess))
                {

                    if (guess < ranNUM)
                    {
                        MessageBox.Show("Too low, try again.");
                        break;
                    }

                    else if (guess > ranNUM)
                    {
                        MessageBox.Show("Too high, try again.");
                        break;
                    }

                }


                else
                {
                    MessageBox.Show("Please enter a valid integer");
                }
            }

            if (guess == ranNUM)
            {
                returnRanNUM();

                MessageBox.Show("Congratulations you guess the right number");
                MessageBox.Show("Play Again!");
                ranNUM = rand.Next(1, 101);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
