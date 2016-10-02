using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostageDeliveryApp___Ch09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            string selection = "";
            selection = Convert.ToString(listBox1.SelectedItem);

            if (selection == "2 Day")
            {
                listBox1.Visible = false;
                labelInitialMessage.Visible = false;
                //this.BackColor
                labelBoxOrLtr.Visible = true;
                listBoxLetterOrBox.Visible = true;
            }
            else if (selection == "Next Day Standard")
            {
                listBox1.Visible = false;
                labelInitialMessage.Visible = false;
                //this.BackColor
                labelBoxOrLtr.Visible = true;
                listBoxLetterOrBox.Visible = true;
            }
            else if (selection == "Next Day Priority") ;
            {
                listBox1.Visible = false;
                labelInitialMessage.Visible = false;
                //this.BackColor
                labelBoxOrLtr.Visible = true;
                listBoxLetterOrBox.Visible = true;
            }
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            string selection = "";
            selection = Convert.ToString(listBoxLetterOrBox.SelectedItem);

            if (selection == "Letter")
            {
                listBoxLetterOrBox.Visible = false;
                labelBoxOrLtr.Visible = false;
                labelHowMuchWeigh.Visible = true;
                textBoxNumOunces.Visible = true;
                buttonCalc.Visible = true;


            }
            else if (selection == "Box")
            {
                listBoxLetterOrBox.Visible = false;
                labelBoxOrLtr.Visible = false;
                labelHowMuchWeigh.Visible = true;
                textBoxNumOunces.Visible = true;
                buttonCalc.Visible = true;
            }
        }

        private void textBoxNumOunces_Click(object sender, EventArgs e)
        {
            //error

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            string input;
            input = textBoxNumOunces.Text;
            double ounces;
            ounces = double.Parse(input);

            buttonCalc.Text = "I did it !!";
        }
    }
}
