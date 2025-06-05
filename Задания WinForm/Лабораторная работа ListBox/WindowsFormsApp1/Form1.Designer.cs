using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            this.analyzeButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.arrayTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.arrayLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // analyzeButton
            // 
            this.analyzeButton.Enabled = false;
            this.analyzeButton.Location = new System.Drawing.Point(180, 100);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(150, 30);
            this.analyzeButton.TabIndex = 0;
            this.analyzeButton.Text = "Проанализировать";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(20, 100);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(150, 30);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Сгенерировать массив";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // arrayTextBox
            // 
            this.arrayTextBox.Location = new System.Drawing.Point(20, 50);
            this.arrayTextBox.Multiline = true;
            this.arrayTextBox.Name = "arrayTextBox";
            this.arrayTextBox.ReadOnly = true;
            this.arrayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.arrayTextBox.Size = new System.Drawing.Size(450, 50);
            this.arrayTextBox.TabIndex = 2;
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(20, 180);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.ReadOnly = true;
            this.countTextBox.Size = new System.Drawing.Size(100, 20);
            this.countTextBox.TabIndex = 3;
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(20, 250);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(450, 95);
            this.resultListBox.TabIndex = 4;
            // 
            // arrayLabel
            // 
            this.arrayLabel.AutoSize = true;
            this.arrayLabel.Location = new System.Drawing.Point(20, 20);
            this.arrayLabel.Name = "arrayLabel";
            this.arrayLabel.Size = new System.Drawing.Size(143, 13);
            this.arrayLabel.TabIndex = 5;
            this.arrayLabel.Text = "Сгенерированный массив:";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(20, 150);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(248, 13);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "Количество элементов, больших предыдущего:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(20, 220);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(184, 13);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Элементы, большие предыдущего:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.arrayLabel);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.arrayTextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.analyzeButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox arrayTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Label arrayLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

