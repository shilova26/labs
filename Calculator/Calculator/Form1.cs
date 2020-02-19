using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Calculator calculator = new Calculator();
        Dictionary<string, Func<double, double>> BinaryOperations;
        public Form1()
        {
            InitializeComponent();
            BinaryOperations = new Dictionary<string, Func<double, double>>();
            BinaryOperations.Add(MinusButton.Name, x => calculator.Minus(x));
            BinaryOperations.Add(PlusButton.Name, x => calculator.Plus(x));
            BinaryOperations.Add(MultiplyyButton.Name, x => calculator.Multiply(x));
            BinaryOperations.Add(DivideButton.Name, x => calculator.Divide(x));
        }

        private double GetCurrentNumber()
        {
            return Convert.ToDouble(EquationTextBox.Text);
        }
        private void Num0Button_Click(object sender, EventArgs e)
        {
            EquationTextBox.Text += "0";
        }

        private void Num1Button_Click(object sender, EventArgs e)
        {
            EquationTextBox.Text += "1";
        }

        private void Num2Button_Click(object sender, EventArgs e)
        {
            EquationTextBox.Text += "2";
        }

        private void Num3Button_Click(object sender, EventArgs e)
        {
            EquationTextBox.Text += "3";
        }
        private void Num4Button_Click(object sender, EventArgs e)
        {
            EquationTextBox.Text += "4";
        }
        private void Num5Button_Click(object sender, EventArgs e)
        {
            EquationTextBox.Text += "5";
        }
        private void Num6Button_Click(object sender, EventArgs e)
        {
            EquationTextBox.Text += "6";
        }
        private void Num7Button_Click(object sender, EventArgs e)
        {
            EquationTextBox.Text += "7";
        }
        private void Num8Button_Click(object sender, EventArgs e)
        {
            EquationTextBox.Text += "8";
        }
        private void Num9Button_Click(object sender, EventArgs e)
        {
            EquationTextBox.Text += "9";
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if(EquationTextBox.Text != "") EquationTextBox.Text= EquationTextBox.Text.Remove(EquationTextBox.Text.Length-1);
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            EquationTextBox.Text = (calculator.Sqrt(GetCurrentNumber())).ToString();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            calculator.Save(GetCurrentNumber());
            EquationTextBox.Clear();
            SetLastButton(MinusButton);
        }

        private void MultiplyyButton_Click(object sender, EventArgs e)
        {
            calculator.Save(GetCurrentNumber());
            EquationTextBox.Clear();
            SetLastButton(MultiplyyButton);
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            calculator.Save(GetCurrentNumber());
            EquationTextBox.Clear();
            SetLastButton(PlusButton);
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            calculator.Save(GetCurrentNumber());
            EquationTextBox.Clear();
            SetLastButton(DivideButton);
        }

        private void ModButton_Click(object sender, EventArgs e)
        {
            calculator.Save(GetCurrentNumber());
            EquationTextBox.Clear();
            SetLastButton(ModButton);
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
              EquationTextBox.Text = (BinaryOperations[GetLastButton().Name](GetCurrentNumber())).ToString();
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            EquationTextBox.Text = calculator.Sign(GetCurrentNumber()).ToString();
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (EquationTextBox.Text.IndexOf(",") != -1) EquationTextBox.Text += ",";
        }

        private Button GetLastButton()
        {
            foreach (Button current in this.Controls.OfType<Button>())
            {
                if (current.Tag.ToString() == "1") return current;
            }
            return null;
        private void SetLastButton(Button button)
        {
            foreach(Button current in this.Controls.OfType<Button>())
            {
                if (current.Name != button.Name) current.Tag = 0;
                else current.Tag = 1;
            }
        }
    }
}
