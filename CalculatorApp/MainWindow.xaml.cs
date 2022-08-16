using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long firstOperand = 0;
        long secondOperand = 0;
        char opr = ' ';

        public MainWindow()
        
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            // Clears the screen and resets operator and operand
            firstOperand = 0;
            secondOperand = 0;
            opr = ' ';
            calcTextBox.Text = "0";
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // Only set operator if not previously set
            if (opr == ' ')
            {
                calcTextBox.Text = "0";
                opr = '+';
            }
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                calcTextBox.Text = "0";
                opr = '-'; 
            }
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                calcTextBox.Text = "0";
                opr = '×'; 
            }
        }
        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                calcTextBox.Text = "0";
                opr = '÷'; 
            }
        }
        private void CalcResult_Click(object sender, RoutedEventArgs e)
        {
            if (firstOperand != 0 && secondOperand != 0)
            {
                Calculator calculator = new Calculator();

                switch (opr)
                {
                    case '+':
                        calcTextBox.Text = calculator.Addition(firstOperand, secondOperand).ToString();
                        break;
                    case '-':
                        calcTextBox.Text = calculator.Subtraction(firstOperand, secondOperand).ToString();
                        break;
                    case '×':
                        calcTextBox.Text = calculator.Multiplication(firstOperand, secondOperand).ToString();
                        break;
                    case '÷':
                        calcTextBox.Text = calculator.Division(firstOperand, secondOperand).ToString();
                        break;
                }
            }
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                firstOperand = (firstOperand * 10);
                calcTextBox.Text = firstOperand.ToString();
            }
            else
            {
                secondOperand = (secondOperand * 10);
                calcTextBox.Text = secondOperand.ToString();
            }
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                firstOperand = (firstOperand * 10) + 1;
                calcTextBox.Text = firstOperand.ToString();
            }
            else
            {
                secondOperand = (secondOperand * 10) + 1;
                calcTextBox.Text = secondOperand.ToString();
            }
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                firstOperand = (firstOperand * 10) + 2;
                calcTextBox.Text = firstOperand.ToString();
            }
            else
            {
                secondOperand = (secondOperand * 10) + 2;
                calcTextBox.Text = secondOperand.ToString();
            }
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                firstOperand = (firstOperand * 10) + 3;
                calcTextBox.Text = firstOperand.ToString();
            }
            else
            {
                secondOperand = (secondOperand * 10) + 3;
                calcTextBox.Text = secondOperand.ToString();
            }
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                firstOperand = (firstOperand * 10) + 4;
                calcTextBox.Text = firstOperand.ToString();
            }
            else
            {
                secondOperand = (secondOperand * 10) + 4;
                calcTextBox.Text = secondOperand.ToString();
            }
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                firstOperand = (firstOperand * 10) + 5;
                calcTextBox.Text = firstOperand.ToString();
            }
            else
            {
                secondOperand = (secondOperand * 10) + 5;
                calcTextBox.Text = secondOperand.ToString();
            }
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                firstOperand = (firstOperand * 10) + 6;
                calcTextBox.Text = firstOperand.ToString();
            }
            else
            {
                secondOperand = (secondOperand * 10) + 6;
                calcTextBox.Text = secondOperand.ToString();
            }
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                firstOperand = (firstOperand * 10) + 7;
                calcTextBox.Text = firstOperand.ToString();
            }
            else
            {
                secondOperand = (secondOperand * 10) + 7;
                calcTextBox.Text = secondOperand.ToString();
            }
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                firstOperand = (firstOperand * 10) + 8;
                calcTextBox.Text = firstOperand.ToString();
            }
            else
            {
                secondOperand = (secondOperand * 10) + 8;
                calcTextBox.Text = secondOperand.ToString();
            }
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                firstOperand = (firstOperand * 10) + 9;
                calcTextBox.Text = firstOperand.ToString();
            }
            else
            {
                secondOperand = (secondOperand * 10) + 9;
                calcTextBox.Text = secondOperand.ToString();
            }
        }

        private void calcTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void clearCurrent_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                firstOperand = 0;
            }
            else
            {
                secondOperand = 0;
            }

            calcTextBox.Text = "0";
        }

        private void backSpaceButton_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                firstOperand = (firstOperand / 10);
                calcTextBox.Text = firstOperand.ToString();
            }
            else
            {
                secondOperand = (secondOperand / 10);
                calcTextBox.Text = secondOperand.ToString();
            }
        }

        private void positiveNegativeButton_Click(object sender, RoutedEventArgs e)
        {
            if (opr == ' ')
            {
                firstOperand *= -1;
                calcTextBox.Text = firstOperand.ToString();
            }
            else
            {
                secondOperand *= -1;
                calcTextBox.Text = secondOperand.ToString();
            }
        }
    }
}
