// Program Name : Technical Support

// Author :        Ndubuisi Christopher Okpala

// Date :          30th March, 2020

// Description :   Rapid App Development for OOSD (CPRG-200-XM5)

//                 This is a GUI program designed to advise the user what to do with a malfunctioning computer.
//                 The user will be made to check a box based on the fault of the computer and there will be
//                 a message display box prompting the user what next to do.
using System;
using System.Windows.Forms;

namespace Computer_Technical_Support_GUI
{
    public partial class GUITechSupport : Form
    {
        public GUITechSupport()
        {
            InitializeComponent();
        }

        // This is to assign an exit command to the quit button
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // This is to assign commands to the check buttons such that when they are checked and
        // clicked on the instruction button, it will advise the user on what to do based on the fault
        // on the computer.

        private void commandButton_Click(object sender, EventArgs e)
        {
            if(computerBeepsCheckBox.Checked && discdriveSpinsCheckBox.Checked)
            {
                commandDisplayLabel.Text = "Bring computer to repair centre";
            }
            else if(!computerBeepsCheckBox.Checked && discdriveSpinsCheckBox.Checked)
            {
                commandDisplayLabel.Text = "Check the speaker contacts";
            }
            else if(computerBeepsCheckBox.Checked && !discdriveSpinsCheckBox.Checked)
            {
                commandDisplayLabel.Text = "Check drive cables";
            }
            else
            {
                commandDisplayLabel.Text = "Contact Tech Support";
            }
        }          
           // This is to make the message display on the command display label to disappear after it has displayed messages before.
        private void checkBoxChanged(object sender, EventArgs e)
        {
            commandDisplayLabel.Text = "";
        }
    }
}
