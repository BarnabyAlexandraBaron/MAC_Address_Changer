﻿namespace MACAddressTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RandomButton = new System.Windows.Forms.Button();
            this.CurrentMacTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ActualMacLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdaptersComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RereadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(519, 93);
            this.RandomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(76, 26);
            this.RandomButton.TabIndex = 0;
            this.RandomButton.Text = "Random";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // CurrentMacTextBox
            // 
            this.CurrentMacTextBox.Location = new System.Drawing.Point(355, 94);
            this.CurrentMacTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CurrentMacTextBox.Name = "CurrentMacTextBox";
            this.CurrentMacTextBox.Size = new System.Drawing.Size(155, 25);
            this.CurrentMacTextBox.TabIndex = 1;
            this.CurrentMacTextBox.TextChanged += new System.EventHandler(this.CurrentMacTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current MAC-address (reported by adapter):";
            // 
            // ActualMacLabel
            // 
            this.ActualMacLabel.AutoSize = true;
            this.ActualMacLabel.Location = new System.Drawing.Point(356, 62);
            this.ActualMacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActualMacLabel.Name = "ActualMacLabel";
            this.ActualMacLabel.Size = new System.Drawing.Size(55, 15);
            this.ActualMacLabel.TabIndex = 3;
            this.ActualMacLabel.Text = "label2";
            this.ActualMacLabel.Click += new System.EventHandler(this.ActualMacLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current MAC-address (from registry):";
            // 
            // AdaptersComboBox
            // 
            this.AdaptersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdaptersComboBox.FormattingEnabled = true;
            this.AdaptersComboBox.Location = new System.Drawing.Point(20, 12);
            this.AdaptersComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AdaptersComboBox.Name = "AdaptersComboBox";
            this.AdaptersComboBox.Size = new System.Drawing.Size(575, 23);
            this.AdaptersComboBox.TabIndex = 5;
            this.AdaptersComboBox.SelectedIndexChanged += new System.EventHandler(this.AdaptersComboBox_SelectedIndexChanged);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(20, 142);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(240, 43);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Update to value";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(355, 142);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(240, 43);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear Value";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RereadButton
            // 
            this.RereadButton.Location = new System.Drawing.Point(519, 51);
            this.RereadButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RereadButton.Name = "RereadButton";
            this.RereadButton.Size = new System.Drawing.Size(76, 26);
            this.RereadButton.TabIndex = 8;
            this.RereadButton.Text = "Update";
            this.RereadButton.UseVisualStyleBackColor = true;
            this.RereadButton.Click += new System.EventHandler(this.RereadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 203);
            this.Controls.Add(this.RereadButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AdaptersComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ActualMacLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentMacTextBox);
            this.Controls.Add(this.RandomButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAC Address Changer  copied by Baron";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.TextBox CurrentMacTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ActualMacLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AdaptersComboBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RereadButton;
    }
}

