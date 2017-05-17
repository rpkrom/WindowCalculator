﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;

            Equalsbutton.Focus();
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            result.Text = ("0");
            value = 0;
            equation.Text = "";
        }

        private void SquareRoot_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Math.Sqrt(Double.Parse(result.Text));
            operation_pressed = true;
            equation.Text = result.Text + operation;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
         
            if (value !=0)
            {
                Equalsbutton.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            equation.Text = "";

            switch (operation)
            {
                case "+":
                    result.Text = Operators.add(value, Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = Operators.subtract(value, Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = Operators.multiply(value, Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = Operators.divide(value, Double.Parse(result.Text)).ToString();
                    break;
                case "√":
                    result.Text = Operators.sqrt(Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;

            }//end switch
            value = Double.Parse(result.Text);
            operation = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    addButton.PerformClick();
                    break;
                case "-":
                    subtractButton.PerformClick();
                    break;
                case "*":
                    multiplyButton.PerformClick();
                    break;
                case "/":
                    divideButton.PerformClick();
                    break;

                default:
                    break;
            }
        }
    }
}
