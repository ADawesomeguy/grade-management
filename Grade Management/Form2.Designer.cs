﻿namespace Grade_Management
{
    partial class InfoForm
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
            this.SchoolLabel = new System.Windows.Forms.Label();
            this.SchoolSelectCBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SchoolLabel
            // 
            this.SchoolLabel.AutoSize = true;
            this.SchoolLabel.Location = new System.Drawing.Point(12, 9);
            this.SchoolLabel.Name = "SchoolLabel";
            this.SchoolLabel.Size = new System.Drawing.Size(77, 13);
            this.SchoolLabel.TabIndex = 0;
            this.SchoolLabel.Text = "Current School";
            // 
            // SchoolSelectCBox
            // 
            this.SchoolSelectCBox.FormattingEnabled = true;
            this.SchoolSelectCBox.Items.AddRange(new object[] {
            "East Lyme High School"});
            this.SchoolSelectCBox.Location = new System.Drawing.Point(95, 6);
            this.SchoolSelectCBox.Name = "SchoolSelectCBox";
            this.SchoolSelectCBox.Size = new System.Drawing.Size(121, 21);
            this.SchoolSelectCBox.TabIndex = 1;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 322);
            this.Controls.Add(this.SchoolSelectCBox);
            this.Controls.Add(this.SchoolLabel);
            this.Name = "InfoForm";
            this.Text = "Input Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SchoolLabel;
        private System.Windows.Forms.ComboBox SchoolSelectCBox;
    }
}