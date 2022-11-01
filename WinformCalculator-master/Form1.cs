using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalculator
{
    public partial class Form1 : Form
    {
        char Operation;
        double Num1, Num2, Result,Cel,Farh,Kel;
        char Operator;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, EventArgs e)
        {
            Screen.Text += 1;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Screen.Text += 2;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            Screen.Text += 3;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Screen.Text += 4;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Screen.Text += 5;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Screen.Text += 6;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Screen.Text += 7;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Screen.Text += 8;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Screen.Text += 9;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            Screen.Text += 0;
        }

        private void ClearScreen_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
        }

      

        private void IsEqualTo_Click(object sender, EventArgs e)
        {
            Num2 = Int32.Parse(Screen.Text);//String to Int 
            switch (Operator)
            {
                case '+':
                    Result = Num1 + Num2;
                    break;

                case '-':
                    Result = Num1 - Num2;
                    break;

                case '*':
                    Result = Num1 * Num2;
                    break;

                case '/':
                    Result = Num1 / Num2;
                    break;

                case '%':
                    Result = Num1 % Num2;
                    break;

            }
            Screen.Text = Result.ToString();
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            Num1 = Int32.Parse(Screen.Text);//String to Int 
            Operator = '+';
            Screen.Text = "";
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            Num1 = Int32.Parse(Screen.Text);//String to Int 
            Operator = '-';
            Screen.Text = "";
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            Num1 = Int32.Parse(Screen.Text);//String to Int 
            Operator = '*';
            Screen.Text = "";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            Num1 = Int32.Parse(Screen.Text);//String to Int 
            Operator = '/';
            Screen.Text = "";
        }

        private void Modulus_Click(object sender, EventArgs e)
        {
            Num1 = Int32.Parse(Screen.Text);//String to Int 
            Operator = '%';
            Screen.Text = "";
        }

        private void BackSpace_Click_1(object sender, EventArgs e)
        {
            if (Screen.Text.Length > 0)
            {
                Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1, 1);
            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 152;
            Screen.Width = 416;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 654;
            Screen.Width = 516;
        }

        private void tempratureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 972;
            Screen.Width = 516;
        }

        private void PI_Click(object sender, EventArgs e)
        {
            Screen.Text += 3.1415;
        }

        private void Logarithm_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(Screen.Text);
            log = Math.Log10(log);
            Screen.Text = System.Convert.ToString(log);
            
        }

        private void SquareRoot_Click(object sender, EventArgs e)
        {
            double Sqroot = Double.Parse(Screen.Text);
            Sqroot = Math.Sqrt(Sqroot);
            Screen.Text = System.Convert.ToString(Sqroot);
        }

        private void Sin_Inverse_Click(object sender, EventArgs e)
        {
            double Sin_h = Double.Parse(Screen.Text);
            Sin_h = Math.Sinh(Sin_h);
            Screen.Text = System.Convert.ToString(Sin_h);
        }

        private void SIN_Click(object sender, EventArgs e)
        {
            double Sim_Sin = Double.Parse(Screen.Text);
            Sim_Sin = Math.Sin(Sim_Sin);
            Screen.Text = System.Convert.ToString(Sim_Sin);
        }

        private void Cos_Inverse_Click(object sender, EventArgs e)
        {
            double Cos_h = Double.Parse(Screen.Text);
            Cos_h = Math.Cosh(Cos_h);
            Screen.Text = System.Convert.ToString(Cos_h);
        }

        private void COS_Click(object sender, EventArgs e)
        {
            double Sim_Cos = Double.Parse(Screen.Text);
            Sim_Cos = Math.Cos(Sim_Cos);
            Screen.Text = System.Convert.ToString(Sim_Cos);
        }

        private void Tan_Inverse_Click(object sender, EventArgs e)
        {
            double Tan_h = Double.Parse(Screen.Text);
            Tan_h = Math.Tanh(Tan_h);
            Screen.Text = System.Convert.ToString(Tan_h);
        }

        private void TAN_Click(object sender, EventArgs e)
        {
            double Sim_Tan = Double.Parse(Screen.Text);
            Sim_Tan = Math.Tan(Sim_Tan);
            Screen.Text = System.Convert.ToString(Sim_Tan);
        }

        private void Binary_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Screen.Text);
            Screen.Text = System.Convert.ToString(a, 2);
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Screen.Text);
            Screen.Text = System.Convert.ToString(a, 10);
        }

        private void Hexadecimal_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Screen.Text);
            Screen.Text = System.Convert.ToString(a, 16);
        }

        private void Power2_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(Screen.Text) * Convert.ToDouble(Screen.Text);
            Screen.Text = System.Convert.ToString(a);
        }

        private void Power3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Screen.Text) * Convert.ToDouble(Screen.Text) * Convert.ToDouble(Screen.Text);
            Screen.Text = System.Convert.ToString(a);
        }

        private void InverseX_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(1.0 / Convert.ToDouble(Screen.Text));
            Screen.Text = System.Convert.ToString(a);
        }

        private void LogX_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(Screen.Text);
            log = Math.Log(log);
            Screen.Text = System.Convert.ToString(log);
        }

        private void C_To_F_Click(object sender, EventArgs e)
        {
            Operation = 'C';
        }

        private void F_To_C_Click(object sender, EventArgs e)
        {
            Operation = 'F';
        }

        private void K_Click(object sender, EventArgs e)
        {
            Operation = 'K';
        }

        private void ConvertHappened_Click(object sender, EventArgs e)
        {
            switch(Operation)
            {
                case 'C':
                    Cel = float.Parse(Screen.Text);
                    Cel = ((9 * Cel) / 5) + 32;
                    Screen.Text = System.Convert.ToString(Cel);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Dot_Click(object sender, EventArgs e)
        {
            Screen.Text = ".";
        }

       

       
    }
}
