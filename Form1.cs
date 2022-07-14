using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Myren_Sutton_M5P13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void list_Click(object sender, EventArgs e)
        {
            int newNUM=0;
            int inputNUM;
            Random rand = new Random();
            if (int.TryParse(num_tb.Text, out inputNUM)) //making sure input number is valid
            {
                try
                {
                    StreamWriter outputfile; //sets up file to start being written

                    outputfile = File.CreateText("Random_Numbers1.txt"); //names the file at first although overwritten during saving process

                    SaveFileDialog saving = new SaveFileDialog(); //intializes saving dialog 

                    if (saving.ShowDialog() == DialogResult.OK)
                    {
                        outputfile = File.CreateText(saving.FileName); 

                        for (int i = 1; i <= inputNUM; i++) //for loop for however numbers the user wants written
                        {

                            newNUM = rand.Next(1, 101); // num through 1 and 100

                            outputfile.WriteLine(newNUM); //writes each new num ona different line
                        }
                    }

                    else
                    {
                        MessageBox.Show("Operation Canceled");
                    }

                    outputfile.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); //error message
                }

            }

            else
            {
                MessageBox.Show("Please enter a valid integer"); //if non-valid int entered
            }
            
        }

    }
}
