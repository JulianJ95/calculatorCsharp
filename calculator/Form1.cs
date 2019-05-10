using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            LabelHistory.Text = "";
           //test



        }

        private bool CheckIfTextBoxResultIsString()
        {//Return true if the textbox is string  else return false
            //that's mean in the TextBoxResult include that string (Can't divde by zero)
            return (!(int.TryParse(TextBoxResult.Text, out int NotRelevant)));
        }
        private void HelperActionsButtonsToSetValue(String ValueToSet)
        {
           
            if (LabelHistory.Text.Contains(ValueToSet))
            {
                return;
            }
            if(TextBoxResult.Text.Remove(0,TextBoxResult.Text.Length-1)==".")
            {
                LabelHistory.Text = TextBoxResult.Text.Remove(TextBoxResult.Text.Length - 1) + ValueToSet;
                return;
            }
            if(!(TextBoxResult.Text.Contains(".")) && CheckIfTextBoxResultIsString())
            {
                TextBoxResult.Clear();
                TextBoxResult.Text = "0";
                LabelHistory.Text = "";
                return;
            }
            
            LabelHistory.Text = TextBoxResult.Text + ValueToSet;
            TextBoxResult.Text = "0";


        }

        private void HelperNumberButtonsToSetValue(string ValueToSet)
        {
              
            if (TextBoxResult.Text == "0")
            {
                TextBoxResult.Clear();
                TextBoxResult.Text = ValueToSet;
                return;
            }
            if (!(TextBoxResult.Text.Contains(".")) && CheckIfTextBoxResultIsString())
            {
                TextBoxResult.Text = "0";
                return;
            }
            TextBoxResult.AppendText(ValueToSet);
            
                
        }
        
        #region EventsOfNumbersButtons
        // Events for all number buttons (0-9)

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
        #endregion

        #region EvetsOfActionsButtons
        //Events for all action buttons (-,+,/,X)
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

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LabelHistory.Text))
                return;
            
            string FristNumber = LabelHistory.Text;
            char Action = FristNumber[FristNumber.Length - 1];
            FristNumber = FristNumber.Substring(0, FristNumber.Length - 1);
            string SecondNumber = TextBoxResult.Text;

            double.TryParse(FristNumber, out double FristNum);
            double.TryParse(SecondNumber, out double SecondNum);

            switch (Action)
            {
                case '+':
                    TextBoxResult.Text = (FristNum + SecondNum).ToString();
                    break;
                case '-':
                    TextBoxResult.Text = (FristNum - SecondNum).ToString();
                    break;
                case 'X':
                    TextBoxResult.Text = (FristNum * SecondNum).ToString();
                    break;
                case '/':
                    if (SecondNum == 0)
                    {
                        TextBoxResult.Text = "Can't divde by zero";

                    }
                    else
                        TextBoxResult.Text = (FristNum / SecondNum).ToString();
                    break;
            }
            LabelHistory.Text = "";

        }
        #endregion

        #region EvertsOfDeleteButtons
        //Events for delete button (C , CE , DEL)
        private void ButtonC_Click(object sender, EventArgs e)
        {//Clear the Text box 
            if (!(TextBoxResult.Text.Contains(".")) && CheckIfTextBoxResultIsString())
            {
                TextBoxResult.Text = "0";
                return;
            }

            TextBoxResult.Clear();
            LabelHistory.Text = "";
            TextBoxResult.Text = "0";
        }
        private void ButtonCE_Click(object sender, EventArgs e)
        {
            if (!(TextBoxResult.Text.Contains(".")) && CheckIfTextBoxResultIsString())
            {
                TextBoxResult.Text = "0";
                return;
            }
            TextBoxResult.Clear();
            TextBoxResult.Text = "0";
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            string ResultValue = TextBoxResult.Text;
            if (!(TextBoxResult.Text.Contains(".")) && CheckIfTextBoxResultIsString())
            {
                TextBoxResult.Text = "0";
                return;
            }

            if (ResultValue.Length > 1)
            {
                ResultValue = ResultValue.Substring(0, ResultValue.Length - 1);
            }
            else
            {
                ResultValue = "0";
            }

            TextBoxResult.Text = ResultValue;
        }

        #endregion

        private void ButtonPlusNegative_Click(object sender, EventArgs e)
        {
            double.TryParse(TextBoxResult.Text, out double NumberToChange);
            NumberToChange = NumberToChange * -1;
            TextBoxResult.Text = NumberToChange.ToString();
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            if (TextBoxResult.Text.Contains(".")||CheckIfTextBoxResultIsString())
                return;
            TextBoxResult.AppendText(".");
        }

    }
}
