// Program Name : Technical Support

// Author :        Ndubuisi Christopher Okpala

// Date :          30th March, 2020

// Description :   Rapid App Development for OOSD (CPRG-200-XM5)

//                 This is a GUI program designed to calculate the area of a Trapezoid
//                 it will ask the user to input the values of two lengths of a Trapezoid and height.
//                 In addition, it will also validate to confirm that the user inputed only numerical values
//                 and if other wise it will display an error message reminding the user the type of data type
//                 that is needed and if corrected will calculate the Trapezoid area and display the value as well.

using System;
using System.Windows.Forms;

namespace GUI_Trapezoid_Area
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // This is to assign exit command to quit button
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double lengthOne;            // this will store the value of lengthOne
            double lengthTwo;            // this will store the value of lenghtTwo
            double height;               // this will store the value of height
            double area;                 // this will store the value of area

            // To carry out data validation and also obtain the values of lengthOne, lengthTwo and height from the user 

            if(!double.TryParse(lengthOfParallelSideTextbox1.Text, out lengthOne))
            {
                MessageBox.Show($"Trapezoid length you entered is not a number. You entered {lengthOne}");
                return;
            }
            if(lengthOne <= 0)
            {
                MessageBox.Show($"Trapezoid length you entered is not a positive number. You entered {lengthOne}");
                return;
            }
            if (!double.TryParse(lengthOfParallelSideTextbox2.Text, out lengthTwo))
            {
                MessageBox.Show($"Trapezoid length you entered is not a number. You entered {lengthTwo}");
                return;
            }
            if (lengthTwo <= 0)
            {
                MessageBox.Show($"Trapezoid length you entered is not a positive number. You entered {lengthTwo}");
                return;
            }
            if (!double.TryParse(heightOfTextbox.Text, out height))
            {
                MessageBox.Show($"Trapezoid height you entered is not a number. You entered {height}");
                return;
            }
            if (height <= 0)
            {
                MessageBox.Show($"Trapezoid length you entered is not a positive number. You entered {height}");
                return;
            }
            // to calculate the value of area and make it display on the display label area

            area = ((lengthOne + lengthTwo) / 2) * height;

            calculateDisplayLabel.Text = $"Area = {area:N2}";

            // to make the length of parallel side one to be focused when the program is lunched

            lengthOfParallelSideTextbox1.Focus();
        }
            // to make the calcualte button active when the program is lunched.
        private void MainForm_Load(object sender, EventArgs e)
        {
            calculateButton.Select();
        }
    }
}

