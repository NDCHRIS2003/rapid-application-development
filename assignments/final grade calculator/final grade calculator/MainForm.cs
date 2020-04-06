// Program Name : Final grade Calculator

// Author :        Ndubuisi Christopher Okpala

// Date :          5th April, 2020

// Description :   Rapid App Development for OOSD (CPRG-200-XM5)

//                 This program will help to calculate the final grade mark of a course as both a percentage and letter
//                 grades. When run, the application will display window form with data entry fields for quiz 
//                 marks, a midterm mark and a final examination mark to be provided by the user. The grades will
//                 calculated using the weighting of 20% for the average quizzes, 30% of the midterm mark and
//                 50% of the final grade. The grade percentage mark is converted to a letter grade using the accepted
//                 grade grid. There are several error/ data validation checks to ensure that the user inputs
//                 only positive numeric values between 0 to 100 and an appropriate error message to display
//                 when this condition is not met.

using System;
using System.Windows.Forms;

namespace final_grade_calculator
{
    public partial class MainForm : Form
       
    {
        int    quizMark;               // this will store the value of quiz mark
        int    midtermMark;            // this will store the value of midterm mark
        int    finalExamMark;          // this will store the value of final exam mark
        double finalCalculatedMark;    // this will store the value of final calculated mark
        int    maxMark;                // this will store the value of maximum mark
        int    minMark;                // this will store the value of the minimum mark
        int    newMark = 0;            // this will store the value of new mark 
        int    numberOfQuizzes = 0;    // this will store the value of number of quizzes
        double quizTotal;              // this will store the value of quiz total

        public MainForm()
        {
            InitializeComponent();
        }
        // this will exit the application after use
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // this is to reset the quiz mark textbox so that the user can input a fresh value
        private void resetQuizMarksButton_Click(object sender, EventArgs e)
        {
            quizMark                          = 0;                     
            maxMark                           = 0;
            minMark                           = 0;
            newMark                           = 0;
            numberOfQuizzes                   = 0;
            quizTotal                         = 0;
            quizMarkInputTextbox.Text         = null;
            multiLineTexbox.Text              = null;
            dropHighestLowestCheckBox.Visible = false;
            
        }
        // this is to send the value of the quiz mark textbox to multiline read only textbox and also set the data
        // sanitization and error control check
        private void transferQuizButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(quizMarkInputTextbox.Text, out quizMark))
            {
                MessageBox.Show("The number you entered is non numeric. Please entere a number between 0-100");
                quizMarkInputTextbox.Text = "";
                quizMarkInputTextbox.Select();               
                return;
            }
            if(quizMark <0 || quizMark > 100)
            {
                MessageBox.Show("The number you entered is invalid.Please entere a number between 0-100");
                quizMarkInputTextbox.Text = "";
                quizMarkInputTextbox.Select();
                return;
            }
            // this is to introduce a loope such that the quiz mark will be automatically summed 
            // and to also make the drop highest and lowest checkbox visible once the number of quiz mark
            // is greater than or equal to 5
            multiLineTexbox.AppendText(quizMarkInputTextbox.Text + Environment.NewLine);
            quizMarkInputTextbox.Text = "";
            quizMarkInputTextbox.Select();
            numberOfQuizzes += 1;
            quizTotal += quizMark;
            newMark += 1;

            if (newMark == 1)
            {
                maxMark = quizMark;
                minMark = quizMark;
            }
            else if (quizMark > maxMark)
            {
                maxMark = quizMark;
            }
            else if (quizMark < minMark)
            {
                minMark = quizMark;
            }

            if(numberOfQuizzes >= 5)
            {
                dropHighestLowestCheckBox.Visible = true;
            }
        }
        // This is to reset all the input values when reset all marks button is clicked
        private void resetMarksButton_Click(object sender, EventArgs e)
        {
            quizMark                           = 0;
            midtermMark                        = 0;
            finalExamMark                      = 0;
            finalCalculatedMark                = 0;
            maxMark                            = 0;
            minMark                            = 0;
            newMark                            = 0;
            numberOfQuizzes                    = 0;
            quizTotal                          = 0;
            quizMarkInputTextbox.Text          = null;
            multiLineTexbox.Text               = null;
            dropHighestLowestCheckBox.Visible  = false;
            midtermMarkTextbox.Text            = null;
            finalExamMarkTextbox.Text          = null;
            calculateTextbox.Text              = null;
            gradeTextbox.Text                  = null;
        }
        // this is to set data validation and error control on midterm and final grade marks
        // provided before calculating grade  
        private void calculateGradeButton_Click(object sender, EventArgs e)
        {
            if(newMark < 1)
            {
                MessageBox.Show("You must enter at least one quiz mark");
                quizMarkInputTextbox.Select();
                return;
            }
            if(!int.TryParse(midtermMarkTextbox.Text, out midtermMark))
            {
                MessageBox.Show("The Midterm mark you entered is non numeric. Please entere a number between 0-100");
                midtermMarkTextbox.Text = "";
                midtermMarkTextbox.Select();
                return;
            }
            if(midtermMark < 0 || midtermMark > 100)
            {
                MessageBox.Show("The number you entered is above the out of range. Please entere a number between 0-100");
                midtermMarkTextbox.Text = "";
                midtermMarkTextbox.Select();
                return;
            }
            if(!int.TryParse(finalExamMarkTextbox.Text, out finalExamMark))
            {
                MessageBox.Show("The Final Exam mark you entered is non numeric. Please entere a number between 0-100");
                finalExamMarkTextbox.Text = "";
                finalExamMarkTextbox.Select();
                return;
            }
            if (finalExamMark < 0 || finalExamMark > 100)
            {
                MessageBox.Show("The final Exam mark you entered is out of range. Please entere a number between 0-100");
                finalExamMarkTextbox.Text = "";
                finalExamMarkTextbox.Select();
                return;
            }

            // this is calcualte the final grades when a checkbos to drop the highest and lowest grade is clicked
            // and also to calculate the final grade if the checkbox is not clicked
            if (dropHighestLowestCheckBox.Checked == true)
            {
                finalCalculatedMark = 0.2 * ((quizTotal - maxMark - minMark) / (numberOfQuizzes - 2)) + 0.3 * midtermMark + 0.5 * finalExamMark;
            }
            else
            {
                finalCalculatedMark = 0.2 * (quizTotal / numberOfQuizzes) + 0.3 * midtermMark + 0.5 * finalExamMark;
            }
            // this will output the score with zero decimal place
            calculateTextbox.Text = $"{finalCalculatedMark:N0}";

            // this is to assign the correct grade to the student based on the quiz score
            if (finalCalculatedMark >= 95)
            {
                gradeTextbox.Text = "A+";
            }
            else if (finalCalculatedMark >= 90 && finalCalculatedMark < 95)
            {
                gradeTextbox.Text = "A";
            }
            else if (finalCalculatedMark >= 85 && finalCalculatedMark < 90)
            {
                gradeTextbox.Text = "A-";
            }
            else if (finalCalculatedMark >= 80 && finalCalculatedMark < 85)
            {
                gradeTextbox.Text = "B+";
            }
            else if (finalCalculatedMark >= 75 && finalCalculatedMark < 80)
            {
                gradeTextbox.Text = "B";
            }
            else if (finalCalculatedMark >= 70 && finalCalculatedMark < 75)
            {
                gradeTextbox.Text = "B-";
            }
            else if (finalCalculatedMark >= 67 && finalCalculatedMark < 70)
            {
                gradeTextbox.Text = "C+";
            }
            else if (finalCalculatedMark >= 64 && finalCalculatedMark < 67)
            {
                gradeTextbox.Text = "C";
            }
            else if (finalCalculatedMark >= 60 && finalCalculatedMark < 64)
            {
                gradeTextbox.Text = "C-";
            }
            else if (finalCalculatedMark >= 55 && finalCalculatedMark < 60)
            {
                gradeTextbox.Text = "D+";
            }
            else if (finalCalculatedMark >= 50 && finalCalculatedMark < 55)
            {
                gradeTextbox.Text = "D";
            }
            else
            {
                gradeTextbox.Text = "F";
            }
        }

        // this is to ensure that once the user starts inputing another grade, the grades and score calculated
        // for the student will disappear.
        private void quizMarkInputTextbox_TextChanged(object sender, EventArgs e)
        {
            gradeTextbox.Text = null;
            calculateTextbox.Text = null;
        }

        private void dropHighestLowestCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            gradeTextbox.Text = null;
            calculateTextbox.Text = null;
        }

        private void midtermMarkTextbox_TextChanged(object sender, EventArgs e)
        {
            gradeTextbox.Text = null;
            calculateTextbox.Text = null;
        }

        private void finalExamMarkTextbox_TextChanged(object sender, EventArgs e)
        {
            gradeTextbox.Text = null;
            calculateTextbox.Text = null;
        }
    }
}
