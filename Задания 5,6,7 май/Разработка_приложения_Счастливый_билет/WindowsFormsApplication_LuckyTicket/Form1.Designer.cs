namespace WindowsFormsApplication_LuckyTicket
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
            this.panel_Variants = new System.Windows.Forms.Panel();
            this.radioButton_VariantTask = new System.Windows.Forms.RadioButton();
            this.radioButton_VariantDefault = new System.Windows.Forms.RadioButton();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.listBox_Enumerate = new System.Windows.Forms.ListBox();
            this.button_CheckVariant = new System.Windows.Forms.Button();
            this.button_FindAllLucky = new System.Windows.Forms.Button();
            this.panel_Variants.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Variants
            // 
            this.panel_Variants.Controls.Add(this.radioButton_VariantTask);
            this.panel_Variants.Controls.Add(this.radioButton_VariantDefault);
            this.panel_Variants.Location = new System.Drawing.Point(12, 56);
            this.panel_Variants.Name = "panel_Variants";
            this.panel_Variants.Size = new System.Drawing.Size(176, 100);
            this.panel_Variants.TabIndex = 0;
            // 
            // radioButton_VariantTask
            // 
            this.radioButton_VariantTask.AutoSize = true;
            this.radioButton_VariantTask.Location = new System.Drawing.Point(15, 49);
            this.radioButton_VariantTask.Name = "radioButton_VariantTask";
            this.radioButton_VariantTask.Size = new System.Drawing.Size(129, 17);
            this.radioButton_VariantTask.TabIndex = 6;
            this.radioButton_VariantTask.TabStop = true;
            this.radioButton_VariantTask.Text = "Вариант по заданию";
            this.radioButton_VariantTask.UseVisualStyleBackColor = true;
            // 
            // radioButton_VariantDefault
            // 
            this.radioButton_VariantDefault.AutoSize = true;
            this.radioButton_VariantDefault.Checked = true;
            this.radioButton_VariantDefault.Location = new System.Drawing.Point(15, 26);
            this.radioButton_VariantDefault.Name = "radioButton_VariantDefault";
            this.radioButton_VariantDefault.Size = new System.Drawing.Size(141, 17);
            this.radioButton_VariantDefault.TabIndex = 5;
            this.radioButton_VariantDefault.TabStop = true;
            this.radioButton_VariantDefault.Text = "Вариант по умолчанию";
            this.radioButton_VariantDefault.UseVisualStyleBackColor = true;
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(44, 30);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(100, 20);
            this.textBox_Input.TabIndex = 1;
            // 
            // listBox_Enumerate
            // 
            this.listBox_Enumerate.FormattingEnabled = true;
            this.listBox_Enumerate.Items.AddRange(new object[] {
            ""});
            this.listBox_Enumerate.Location = new System.Drawing.Point(199, 12);
            this.listBox_Enumerate.Name = "listBox_Enumerate";
            this.listBox_Enumerate.Size = new System.Drawing.Size(120, 290);
            this.listBox_Enumerate.TabIndex = 2;
            // 
            // button_CheckVariant
            // 
            this.button_CheckVariant.Location = new System.Drawing.Point(12, 176);
            this.button_CheckVariant.Name = "button_CheckVariant";
            this.button_CheckVariant.Size = new System.Drawing.Size(176, 45);
            this.button_CheckVariant.TabIndex = 3;
            this.button_CheckVariant.Text = "Проверить результат";
            this.button_CheckVariant.UseVisualStyleBackColor = true;
            this.button_CheckVariant.Click += new System.EventHandler(this.button_CheckVariant_Click);
            // 
            // button_FindAllLucky
            // 
            this.button_FindAllLucky.Location = new System.Drawing.Point(12, 243);
            this.button_FindAllLucky.Name = "button_FindAllLucky";
            this.button_FindAllLucky.Size = new System.Drawing.Size(176, 45);
            this.button_FindAllLucky.TabIndex = 4;
            this.button_FindAllLucky.Text = "Найти все счастливые числа";
            this.button_FindAllLucky.UseVisualStyleBackColor = true;
            this.button_FindAllLucky.Click += new System.EventHandler(this.button_FindAllLucky_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 321);
            this.Controls.Add(this.button_FindAllLucky);
            this.Controls.Add(this.button_CheckVariant);
            this.Controls.Add(this.listBox_Enumerate);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.panel_Variants);
            this.Name = "Form_Main";
            this.Text = "Проверка счастливого билета";
            this.panel_Variants.ResumeLayout(false);
            this.panel_Variants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Variants;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.ListBox listBox_Enumerate;
        private System.Windows.Forms.RadioButton radioButton_VariantTask;
        private System.Windows.Forms.RadioButton radioButton_VariantDefault;
        private System.Windows.Forms.Button button_CheckVariant;
        private System.Windows.Forms.Button button_FindAllLucky;
    }
}

