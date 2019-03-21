using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if ((textBoximie.Text.Length <= 0) || (textBoxnazwisko.Text.Length <= 0))
            {
                labelKomunikat1.Text = "";
                labelKomunikat2.Text = "";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            labelKomunikat1.Text = "Witaj, " + textBoximie.Text + " " + textBoxnazwisko.Text + "!";
            if(textBoxWiek.Text.Length <= 0)
            {
                labelKomunikat2.Text = "";
            }
            else
            {
                int wiek = Convert.ToInt32(textBoxWiek.Text);

                if (wiek < 0)
                {
                    labelKomunikat2.Text = "Błąd Danych!";
                }
                else if (wiek < 67)
                {
                    labelKomunikat2.Text = "Do twojego wieku emerytalnego pozostało: " + (67 - wiek) + " lat";
                }
                else
                {
                    labelKomunikat2.Text = "Gratulacje! Możesz cieszyć się emeryturą!";
                }
            }


        }
    }
}
