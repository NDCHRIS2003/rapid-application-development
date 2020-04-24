// Program Name : gui array search

// Author :        Ndubuisi Christopher Okpala

// Date :          24th March, 2020

// Description :   Rapid App Development for OOSD (CPRG-200-XM5)

//                 This is to create GUI application that will generate a random numbers
//                 immediately the program is launched. The user will have a textbox that
//                 can be used to determine the index of any random number generated. The 
//                 index of the random number will be displayed to the user if it is availabe
//                 if not, an approriate error message will be displayed to the user.
using System;
using System.Windows.Forms;

namespace gui_array_search
{
    public partial class MainForm : Form
    {
        const int ARRAY_SIZE    = 10;                        // this will store the value of array size
        const int MAXIMUM_VALUE = 99;                        // this will store the value of the maximum size of the array
        const int MINIMUM_VALUE = 10;                        // this will store the value of the minimum size of the array    
        int       numberValue;                               // this will store the iteration values of array       
        int[] myRandomNumbers   = new int[ARRAY_SIZE];       // this is to declare the array with the size in it
        System.Random random    = new System.Random();       // this is to declare the random integer
        string    variable      = "";                        // this will store the string arrays

        public MainForm()
        {
            InitializeComponent();
        }
        // this is to add event handler on the window's form to make the array values display once the form app 
        // is loaded

        private void MainForm_Load(object sender, EventArgs e)
        {
            for(numberValue = 0; numberValue < ARRAY_SIZE; numberValue++)
            {
                myRandomNumbers[numberValue] = random.Next(MINIMUM_VALUE, MAXIMUM_VALUE);

                variable += $"{myRandomNumbers[numberValue]} ";

                randomNumberDisplayTextbox.Text = variable;
            }


        }
        // this is to add event handler on the search button such that when a value is entered on the textbox
        // it will validate if we have the integer on the array and display the appropriate message 
        private void searchButton_Click(object sender, EventArgs e)
        {
            int index = Array.IndexOf(myRandomNumbers, int.Parse(valueTextbox.Text));
            

            if(index == -1)
            {
                searchDisplayLabel.Text = $"The value {valueTextbox.Text} was NOT found";
                return;
            }
            else
            {
                searchDisplayLabel.Text = $"The value {valueTextbox.Text} was found at index {index}";
            }

            valueTextbox.Select();
        }
    }
}
