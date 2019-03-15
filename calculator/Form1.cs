using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int StartText = 0;
            InitializeComponent();
            TextBoxResult.Text =StartText.ToString();
            TextBoxResult.Enabled = false;
            


        }

        private void HelperActionsButtonsToSetValue(String ValueToSet)
        {
            if (TextBoxResult.Text.Contains(ValueToSet))
                return;
            TextBoxResult.AppendText(ValueToSet);
        }
        private void HelperNumberButtonsToSetValue(string ValueToSet)
        {//Function that get a string the string is number (0-9)
            //then check if the text is 0 that mean it's the start 
            //it's clear and set the number that got 
            //else it's appead to the text that already in the textbox

            if (TextBoxResult.Text == "0")
            {
                TextBoxResult.Clear();
                TextBoxResult.Text = ValueToSet;
            }

            else
                TextBoxResult.AppendText(ValueToSet);
        }
        private void ButtonNumber0_Click(object sender, EventArgs e)
        {
            HelperNumberButtonsToSetValue("0");
        }

        private void ButtonNumber1_Click(object sender, EventArgs e)
        {
            HelperNumberButtonsToSetValue("1");
        }

        private void ButtonNumber2_Click(object sender, EventArgs e)
        {
            HelperNumberButtonsToSetValue("2");
        }

        private void ButtonNumber3_Click(object sender, EventArgs e)
        {
            HelperNumberButtonsToSetValue("3");
        }

        private void ButtonNumber4_Click(object sender, EventArgs e)
        {
            HelperNumberButtonsToSetValue("4");
        }

        private void ButtonNumber5_Click(object sender, EventArgs e)
        {
            HelperNumberButtonsToSetValue("5");
        }

        private void ButtonNumber6_Click(object sender, EventArgs e)
        {
            HelperNumberButtonsToSetValue("6");
        }

        private void ButtonNumber7_Click(object sender, EventArgs e)
        {
            HelperNumberButtonsToSetValue("7");
        }

        private void ButtonNumber8_Click(object sender, EventArgs e)
        {
            HelperNumberButtonsToSetValue("8");
        }

        private void ButtonNumber9_Click(object sender, EventArgs e)
        {
            HelperNumberButtonsToSetValue("9");
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {//Clear the Text box 
            TextBoxResult.Clear();
        }

        private void ButtonDivision_Click(object sender, EventArgs e)
        {
            HelperActionsButtonsToSetValue("/");
        }

        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            HelperActionsButtonsToSetValue("X");
        }

        private void ButtonSum_Click(object sender, EventArgs e)
        {
            HelperActionsButtonsToSetValue("+");
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            HelperActionsButtonsToSetValue("-");
        }
    }
}
