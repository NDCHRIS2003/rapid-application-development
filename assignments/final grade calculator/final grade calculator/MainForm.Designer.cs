namespace final_grade_calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.multiLineTexbox = new System.Windows.Forms.TextBox();
            this.quizMarkInputTextbox = new System.Windows.Forms.TextBox();
            this.transferQuizButton = new System.Windows.Forms.Button();
            this.quizMarkLabel = new System.Windows.Forms.Label();
            this.resetQuizMarksButton = new System.Windows.Forms.Button();
            this.dropHighestLowestCheckBox = new System.Windows.Forms.CheckBox();
            this.midtermMarkTextbox = new System.Windows.Forms.TextBox();
            this.finalExamMarkTextbox = new System.Windows.Forms.TextBox();
            this.midtermMarkLabel = new System.Windows.Forms.Label();
            this.finalExamMarkLabel = new System.Windows.Forms.Label();
            this.calculateGradeButton = new System.Windows.Forms.Button();
            this.resetMarksButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.calculateTextbox = new System.Windows.Forms.TextBox();
            this.gradeTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // multiLineTexbox
            // 
            this.multiLineTexbox.Location = new System.Drawing.Point(264, 12);
            this.multiLineTexbox.Multiline = true;
            this.multiLineTexbox.Name = "multiLineTexbox";
            this.multiLineTexbox.ReadOnly = true;
            this.multiLineTexbox.Size = new System.Drawing.Size(100, 161);
            this.multiLineTexbox.TabIndex = 0;
            // 
            // quizMarkInputTextbox
            // 
            this.quizMarkInputTextbox.Location = new System.Drawing.Point(88, 27);
            this.quizMarkInputTextbox.Multiline = true;
            this.quizMarkInputTextbox.Name = "quizMarkInputTextbox";
            this.quizMarkInputTextbox.Size = new System.Drawing.Size(72, 41);
            this.quizMarkInputTextbox.TabIndex = 1;
            this.quizMarkInputTextbox.TextChanged += new System.EventHandler(this.quizMarkInputTextbox_TextChanged);
            // 
            // transferQuizButton
            // 
            this.transferQuizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferQuizButton.Location = new System.Drawing.Point(187, 27);
            this.transferQuizButton.Name = "transferQuizButton";
            this.transferQuizButton.Size = new System.Drawing.Size(58, 41);
            this.transferQuizButton.TabIndex = 2;
            this.transferQuizButton.Text = "➔";
            this.transferQuizButton.UseVisualStyleBackColor = true;
            this.transferQuizButton.Click += new System.EventHandler(this.transferQuizButton_Click);
            // 
            // quizMarkLabel
            // 
            this.quizMarkLabel.AutoSize = true;
            this.quizMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizMarkLabel.Location = new System.Drawing.Point(5, 43);
            this.quizMarkLabel.Name = "quizMarkLabel";
            this.quizMarkLabel.Size = new System.Drawing.Size(77, 18);
            this.quizMarkLabel.TabIndex = 3;
            this.quizMarkLabel.Text = "Quiz Mark";
            this.quizMarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetQuizMarksButton
            // 
            this.resetQuizMarksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetQuizMarksButton.Location = new System.Drawing.Point(12, 87);
            this.resetQuizMarksButton.Name = "resetQuizMarksButton";
            this.resetQuizMarksButton.Size = new System.Drawing.Size(233, 32);
            this.resetQuizMarksButton.TabIndex = 4;
            this.resetQuizMarksButton.Text = "Reset Quiz Marks";
            this.resetQuizMarksButton.UseVisualStyleBackColor = true;
            this.resetQuizMarksButton.Click += new System.EventHandler(this.resetQuizMarksButton_Click);
            // 
            // dropHighestLowestCheckBox
            // 
            this.dropHighestLowestCheckBox.AutoSize = true;
            this.dropHighestLowestCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropHighestLowestCheckBox.Location = new System.Drawing.Point(161, 196);
            this.dropHighestLowestCheckBox.Name = "dropHighestLowestCheckBox";
            this.dropHighestLowestCheckBox.Size = new System.Drawing.Size(229, 22);
            this.dropHighestLowestCheckBox.TabIndex = 5;
            this.dropHighestLowestCheckBox.Text = "Drop Highest & Lowest Quizzes";
            this.dropHighestLowestCheckBox.UseVisualStyleBackColor = true;
            this.dropHighestLowestCheckBox.Visible = false;
            this.dropHighestLowestCheckBox.CheckedChanged += new System.EventHandler(this.dropHighestLowestCheckBox_CheckedChanged);
            // 
            // midtermMarkTextbox
            // 
            this.midtermMarkTextbox.Location = new System.Drawing.Point(264, 224);
            this.midtermMarkTextbox.Multiline = true;
            this.midtermMarkTextbox.Name = "midtermMarkTextbox";
            this.midtermMarkTextbox.Size = new System.Drawing.Size(100, 41);
            this.midtermMarkTextbox.TabIndex = 6;
            this.midtermMarkTextbox.TextChanged += new System.EventHandler(this.midtermMarkTextbox_TextChanged);
            // 
            // finalExamMarkTextbox
            // 
            this.finalExamMarkTextbox.Location = new System.Drawing.Point(264, 287);
            this.finalExamMarkTextbox.Multiline = true;
            this.finalExamMarkTextbox.Name = "finalExamMarkTextbox";
            this.finalExamMarkTextbox.Size = new System.Drawing.Size(100, 41);
            this.finalExamMarkTextbox.TabIndex = 7;
            this.finalExamMarkTextbox.TextChanged += new System.EventHandler(this.finalExamMarkTextbox_TextChanged);
            // 
            // midtermMarkLabel
            // 
            this.midtermMarkLabel.AutoSize = true;
            this.midtermMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midtermMarkLabel.Location = new System.Drawing.Point(158, 234);
            this.midtermMarkLabel.Name = "midtermMarkLabel";
            this.midtermMarkLabel.Size = new System.Drawing.Size(100, 18);
            this.midtermMarkLabel.TabIndex = 8;
            this.midtermMarkLabel.Text = "Midterm Mark";
            // 
            // finalExamMarkLabel
            // 
            this.finalExamMarkLabel.AutoSize = true;
            this.finalExamMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalExamMarkLabel.Location = new System.Drawing.Point(139, 298);
            this.finalExamMarkLabel.Name = "finalExamMarkLabel";
            this.finalExamMarkLabel.Size = new System.Drawing.Size(119, 18);
            this.finalExamMarkLabel.TabIndex = 9;
            this.finalExamMarkLabel.Text = "Final Exam Mark";
            // 
            // calculateGradeButton
            // 
            this.calculateGradeButton.Location = new System.Drawing.Point(142, 360);
            this.calculateGradeButton.Name = "calculateGradeButton";
            this.calculateGradeButton.Size = new System.Drawing.Size(140, 32);
            this.calculateGradeButton.TabIndex = 10;
            this.calculateGradeButton.Text = "Calculate Grade";
            this.calculateGradeButton.UseVisualStyleBackColor = true;
            this.calculateGradeButton.Click += new System.EventHandler(this.calculateGradeButton_Click);
            // 
            // resetMarksButton
            // 
            this.resetMarksButton.Location = new System.Drawing.Point(142, 416);
            this.resetMarksButton.Name = "resetMarksButton";
            this.resetMarksButton.Size = new System.Drawing.Size(140, 32);
            this.resetMarksButton.TabIndex = 11;
            this.resetMarksButton.Text = "Reset All Marks";
            this.resetMarksButton.UseVisualStyleBackColor = true;
            this.resetMarksButton.Click += new System.EventHandler(this.resetMarksButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(142, 465);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(140, 32);
            this.quitButton.TabIndex = 12;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // calculateTextbox
            // 
            this.calculateTextbox.Location = new System.Drawing.Point(288, 360);
            this.calculateTextbox.Multiline = true;
            this.calculateTextbox.Name = "calculateTextbox";
            this.calculateTextbox.ReadOnly = true;
            this.calculateTextbox.Size = new System.Drawing.Size(48, 32);
            this.calculateTextbox.TabIndex = 13;
            // 
            // gradeTextbox
            // 
            this.gradeTextbox.Location = new System.Drawing.Point(349, 360);
            this.gradeTextbox.Multiline = true;
            this.gradeTextbox.Name = "gradeTextbox";
            this.gradeTextbox.ReadOnly = true;
            this.gradeTextbox.Size = new System.Drawing.Size(48, 32);
            this.gradeTextbox.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 509);
            this.Controls.Add(this.gradeTextbox);
            this.Controls.Add(this.calculateTextbox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.resetMarksButton);
            this.Controls.Add(this.calculateGradeButton);
            this.Controls.Add(this.finalExamMarkLabel);
            this.Controls.Add(this.midtermMarkLabel);
            this.Controls.Add(this.finalExamMarkTextbox);
            this.Controls.Add(this.midtermMarkTextbox);
            this.Controls.Add(this.dropHighestLowestCheckBox);
            this.Controls.Add(this.resetQuizMarksButton);
            this.Controls.Add(this.quizMarkLabel);
            this.Controls.Add(this.transferQuizButton);
            this.Controls.Add(this.quizMarkInputTextbox);
            this.Controls.Add(this.multiLineTexbox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Grade Calculator";
            this.CursorChanged += new System.EventHandler(this.quizMarkInputTextbox_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox multiLineTexbox;
        private System.Windows.Forms.TextBox quizMarkInputTextbox;
        private System.Windows.Forms.Button transferQuizButton;
        private System.Windows.Forms.Label quizMarkLabel;
        private System.Windows.Forms.Button resetQuizMarksButton;
        private System.Windows.Forms.CheckBox dropHighestLowestCheckBox;
        private System.Windows.Forms.TextBox midtermMarkTextbox;
        private System.Windows.Forms.TextBox finalExamMarkTextbox;
        private System.Windows.Forms.Label midtermMarkLabel;
        private System.Windows.Forms.Label finalExamMarkLabel;
        private System.Windows.Forms.Button calculateGradeButton;
        private System.Windows.Forms.Button resetMarksButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.TextBox calculateTextbox;
        private System.Windows.Forms.TextBox gradeTextbox;
    }
}

