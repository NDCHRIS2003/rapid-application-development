namespace GUI_Trapezoid_Area
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
            this.lengthOfParallelSideLabel1 = new System.Windows.Forms.Label();
            this.lengthOfParallelSideLabel2 = new System.Windows.Forms.Label();
            this.lengthOfHeightLabel = new System.Windows.Forms.Label();
            this.lengthOfParallelSideTextbox1 = new System.Windows.Forms.TextBox();
            this.lengthOfParallelSideTextbox2 = new System.Windows.Forms.TextBox();
            this.heightOfTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.calculateDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lengthOfParallelSideLabel1
            // 
            this.lengthOfParallelSideLabel1.AutoSize = true;
            this.lengthOfParallelSideLabel1.Location = new System.Drawing.Point(28, 13);
            this.lengthOfParallelSideLabel1.Name = "lengthOfParallelSideLabel1";
            this.lengthOfParallelSideLabel1.Size = new System.Drawing.Size(122, 13);
            this.lengthOfParallelSideLabel1.TabIndex = 0;
            this.lengthOfParallelSideLabel1.Text = "Length of Parallel Side 1";
            // 
            // lengthOfParallelSideLabel2
            // 
            this.lengthOfParallelSideLabel2.AutoSize = true;
            this.lengthOfParallelSideLabel2.Location = new System.Drawing.Point(28, 46);
            this.lengthOfParallelSideLabel2.Name = "lengthOfParallelSideLabel2";
            this.lengthOfParallelSideLabel2.Size = new System.Drawing.Size(122, 13);
            this.lengthOfParallelSideLabel2.TabIndex = 1;
            this.lengthOfParallelSideLabel2.Text = "Length of Parallel Side 2";
            // 
            // lengthOfHeightLabel
            // 
            this.lengthOfHeightLabel.AutoSize = true;
            this.lengthOfHeightLabel.Location = new System.Drawing.Point(68, 82);
            this.lengthOfHeightLabel.Name = "lengthOfHeightLabel";
            this.lengthOfHeightLabel.Size = new System.Drawing.Size(82, 13);
            this.lengthOfHeightLabel.TabIndex = 2;
            this.lengthOfHeightLabel.Text = "length of Height";
            // 
            // lengthOfParallelSideTextbox1
            // 
            this.lengthOfParallelSideTextbox1.Location = new System.Drawing.Point(171, 10);
            this.lengthOfParallelSideTextbox1.Name = "lengthOfParallelSideTextbox1";
            this.lengthOfParallelSideTextbox1.Size = new System.Drawing.Size(100, 20);
            this.lengthOfParallelSideTextbox1.TabIndex = 3;
            // 
            // lengthOfParallelSideTextbox2
            // 
            this.lengthOfParallelSideTextbox2.Location = new System.Drawing.Point(171, 43);
            this.lengthOfParallelSideTextbox2.Name = "lengthOfParallelSideTextbox2";
            this.lengthOfParallelSideTextbox2.Size = new System.Drawing.Size(100, 20);
            this.lengthOfParallelSideTextbox2.TabIndex = 3;
            // 
            // heightOfTextbox
            // 
            this.heightOfTextbox.Location = new System.Drawing.Point(171, 79);
            this.heightOfTextbox.Name = "heightOfTextbox";
            this.heightOfTextbox.Size = new System.Drawing.Size(100, 20);
            this.heightOfTextbox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(31, 136);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(31, 176);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // calculateDisplayLabel
            // 
            this.calculateDisplayLabel.AutoSize = true;
            this.calculateDisplayLabel.Location = new System.Drawing.Point(168, 141);
            this.calculateDisplayLabel.Name = "calculateDisplayLabel";
            this.calculateDisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.calculateDisplayLabel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 216);
            this.Controls.Add(this.calculateDisplayLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.lengthOfParallelSideTextbox2);
            this.Controls.Add(this.heightOfTextbox);
            this.Controls.Add(this.lengthOfParallelSideTextbox1);
            this.Controls.Add(this.lengthOfHeightLabel);
            this.Controls.Add(this.lengthOfParallelSideLabel2);
            this.Controls.Add(this.lengthOfParallelSideLabel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI Trapezoid Area Version 0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lengthOfParallelSideLabel1;
        private System.Windows.Forms.Label lengthOfParallelSideLabel2;
        private System.Windows.Forms.Label lengthOfHeightLabel;
        private System.Windows.Forms.TextBox lengthOfParallelSideTextbox1;
        private System.Windows.Forms.TextBox lengthOfParallelSideTextbox2;
        private System.Windows.Forms.TextBox heightOfTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label calculateDisplayLabel;
    }
}

