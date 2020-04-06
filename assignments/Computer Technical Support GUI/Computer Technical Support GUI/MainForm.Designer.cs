namespace Computer_Technical_Support_GUI
{
    partial class GUITechSupport
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
            this.computerBeepsCheckBox = new System.Windows.Forms.CheckBox();
            this.discdriveSpinsCheckBox = new System.Windows.Forms.CheckBox();
            this.commandButton = new System.Windows.Forms.Button();
            this.commandDisplayLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // computerBeepsCheckBox
            // 
            this.computerBeepsCheckBox.AutoSize = true;
            this.computerBeepsCheckBox.Location = new System.Drawing.Point(142, 12);
            this.computerBeepsCheckBox.Name = "computerBeepsCheckBox";
            this.computerBeepsCheckBox.Size = new System.Drawing.Size(104, 17);
            this.computerBeepsCheckBox.TabIndex = 0;
            this.computerBeepsCheckBox.Text = "Computer Beeps";
            this.computerBeepsCheckBox.UseVisualStyleBackColor = true;
            this.computerBeepsCheckBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            // 
            // discdriveSpinsCheckBox
            // 
            this.discdriveSpinsCheckBox.AutoSize = true;
            this.discdriveSpinsCheckBox.Location = new System.Drawing.Point(142, 47);
            this.discdriveSpinsCheckBox.Name = "discdriveSpinsCheckBox";
            this.discdriveSpinsCheckBox.Size = new System.Drawing.Size(99, 17);
            this.discdriveSpinsCheckBox.TabIndex = 1;
            this.discdriveSpinsCheckBox.Text = "Discdrive Spins";
            this.discdriveSpinsCheckBox.UseVisualStyleBackColor = true;
            this.discdriveSpinsCheckBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            // 
            // commandButton
            // 
            this.commandButton.Location = new System.Drawing.Point(142, 87);
            this.commandButton.Name = "commandButton";
            this.commandButton.Size = new System.Drawing.Size(104, 23);
            this.commandButton.TabIndex = 2;
            this.commandButton.Text = "What should I do";
            this.commandButton.UseVisualStyleBackColor = true;
            this.commandButton.Click += new System.EventHandler(this.commandButton_Click);
            // 
            // commandDisplayLabel
            // 
            this.commandDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commandDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandDisplayLabel.ForeColor = System.Drawing.Color.Red;
            this.commandDisplayLabel.Location = new System.Drawing.Point(23, 123);
            this.commandDisplayLabel.Name = "commandDisplayLabel";
            this.commandDisplayLabel.Size = new System.Drawing.Size(320, 55);
            this.commandDisplayLabel.TabIndex = 4;
            this.commandDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(142, 190);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(104, 23);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // GUITechSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 225);
            this.Controls.Add(this.discdriveSpinsCheckBox);
            this.Controls.Add(this.computerBeepsCheckBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.commandDisplayLabel);
            this.Controls.Add(this.commandButton);
            this.Name = "GUITechSupport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technical Support";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox computerBeepsCheckBox;
        private System.Windows.Forms.CheckBox discdriveSpinsCheckBox;
        private System.Windows.Forms.Button commandButton;
        private System.Windows.Forms.Label commandDisplayLabel;
        private System.Windows.Forms.Button quitButton;
    }
}

