namespace WinFormsApp_SaveLoadFragments
{
    partial class Form_Main
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
            this.radioButton_SaveAs = new System.Windows.Forms.RadioButton();
            this.radioButton_Load = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_close = new System.Windows.Forms.Button();
            this.radioButton_Swap = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_SaveAs
            // 
            this.radioButton_SaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton_SaveAs.Location = new System.Drawing.Point(148, 300);
            this.radioButton_SaveAs.Name = "radioButton_SaveAs";
            this.radioButton_SaveAs.Size = new System.Drawing.Size(152, 17);
            this.radioButton_SaveAs.TabIndex = 0;
            this.radioButton_SaveAs.TabStop = true;
            this.radioButton_SaveAs.Text = "Сохранить фрагмент как";
            this.radioButton_SaveAs.UseVisualStyleBackColor = true;
            // 
            // radioButton_Load
            // 
            this.radioButton_Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton_Load.Location = new System.Drawing.Point(12, 300);
            this.radioButton_Load.Name = "radioButton_Load";
            this.radioButton_Load.Size = new System.Drawing.Size(130, 17);
            this.radioButton_Load.TabIndex = 1;
            this.radioButton_Load.TabStop = true;
            this.radioButton_Load.Text = "Загрузить фрагмент";
            this.radioButton_Load.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 11);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(616, 280);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.Location = new System.Drawing.Point(580, 297);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(49, 23);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "Выход";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // radioButton_Swap
            // 
            this.radioButton_Swap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton_Swap.AutoSize = true;
            this.radioButton_Swap.Location = new System.Drawing.Point(306, 300);
            this.radioButton_Swap.Name = "radioButton_Swap";
            this.radioButton_Swap.Size = new System.Drawing.Size(124, 17);
            this.radioButton_Swap.TabIndex = 4;
            this.radioButton_Swap.TabStop = true;
            this.radioButton_Swap.Text = "Обмен фрагментов";
            this.radioButton_Swap.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(436, 300);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(148, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Загрузить изображение";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 326);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton_Swap);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.radioButton_Load);
            this.Controls.Add(this.radioButton_SaveAs);
            this.Name = "Form_Main";
            this.Text = "Сохранение и загрузка фрагментов изображений";
            this.SizeChanged += new System.EventHandler(this.Form_Main_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_SaveAs;
        private System.Windows.Forms.RadioButton radioButton_Load;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.RadioButton radioButton_Swap;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

