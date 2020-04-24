namespace gui_array_search
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
            this.randomNumberLabel = new System.Windows.Forms.Label();
            this.randomNumberDisplayTextbox = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.valueTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // randomNumberLabel
            // 
            this.randomNumberLabel.AutoSize = true;
            this.randomNumberLabel.Location = new System.Drawing.Point(22, 13);
            this.randomNumberLabel.Name = "randomNumberLabel";
            this.randomNumberLabel.Size = new System.Drawing.Size(106, 13);
            this.randomNumberLabel.TabIndex = 0;
            this.randomNumberLabel.Text = "Random Number List";
            // 
            // randomNumberDisplayTextbox
            // 
            this.randomNumberDisplayTextbox.Location = new System.Drawing.Point(134, 10);
            this.randomNumberDisplayTextbox.Name = "randomNumberDisplayTextbox";
            this.randomNumberDisplayTextbox.ReadOnly = true;
            this.randomNumberDisplayTextbox.Size = new System.Drawing.Size(497, 20);
            this.randomNumberDisplayTextbox.TabIndex = 1;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(25, 78);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(89, 13);
            this.valueLabel.TabIndex = 2;
            this.valueLabel.Text = "Value Search For";
            // 
            // valueTextbox
            // 
            this.valueTextbox.Location = new System.Drawing.Point(134, 78);
            this.valueTextbox.Name = "valueTextbox";
            this.valueTextbox.Size = new System.Drawing.Size(74, 20);
            this.valueTextbox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(232, 78);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchDisplayLabel
            // 
            this.searchDisplayLabel.Location = new System.Drawing.Point(337, 78);
            this.searchDisplayLabel.Name = "searchDisplayLabel";
            this.searchDisplayLabel.Size = new System.Drawing.Size(235, 23);
            this.searchDisplayLabel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 139);
            this.Controls.Add(this.searchDisplayLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.valueTextbox);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.randomNumberDisplayTextbox);
            this.Controls.Add(this.randomNumberLabel);
            this.Name = "MainForm";
            this.Text = "Searching an Array GUI Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label randomNumberLabel;
        private System.Windows.Forms.TextBox randomNumberDisplayTextbox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox valueTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchDisplayLabel;
    }
}

