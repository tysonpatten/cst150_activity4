// tyson patten
// gcu
// cst 150 activity 4
// time calculator

// this is my own work

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150___Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numSeconds = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // converts the textbox to an int

            try
            {
                numSeconds = Convert.ToInt32(textBox1.Text);
            }
            catch 
            {
                numSeconds = -1; // makes any invalid input (like a string) prompt first IF statement
            }

        }

        private void submitButton_Click(object sender, EventArgs e)
        {   
            // rejects invalid input
            if (numSeconds < 0)
            {
                displayMessage.Text = "Invalid Number. Enter a positive number.";
            }
            // 0 to 60, displays seconds
            else if (numSeconds >= 0 && numSeconds < 60)
            {
                displayMessage.Text = "That many seconds = " + numSeconds + " seconds";
            }
            // 60 to 3600, displays minutes
            else if (numSeconds >= 60 && numSeconds < 3600)
            {
                displayMessage.Text = "That many seconds = " + numSeconds / 60 + " minutes.";
            }
            // 3600 to 86400, displays hours
            else if (numSeconds >= 3600 && numSeconds < 86400)
            {
                displayMessage.Text = "That many seconds = " + numSeconds / 3600 + " hours.";
            }
            // 86400 or more, display days
            else if (numSeconds >= 86400 && numSeconds < 31_536_000)
            {
                displayMessage.Text = "That many seconds = " + numSeconds / 86400 + " days.";
            }
            // added years for fun
            else
            {
                displayMessage.Text = "That many seconds = " + (numSeconds / 31_536_000 + " years.");
            }
        }
    }
}
