namespace WinFormsApp_ImpUserInterface
{
    partial class form_Main
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
            this.panel_Output = new System.Windows.Forms.Panel();
            this.label_Output = new System.Windows.Forms.Label();
            this.textBox_InputValue = new System.Windows.Forms.TextBox();
            this.vScrollBar_InputValue = new System.Windows.Forms.VScrollBar();
            this.pictureBox_Formula = new System.Windows.Forms.PictureBox();
            this.label_InputValue = new System.Windows.Forms.Label();
            this.button_EvaluateVariant = new System.Windows.Forms.Button();
            this.button_EvaluateAllDefault = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.label_InputTaskNum = new System.Windows.Forms.Label();
            this.comboBox_TaskNum = new System.Windows.Forms.ComboBox();
            this.panel_Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Formula)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Output
            // 
            this.panel_Output.Controls.Add(this.label_Output);
            this.panel_Output.Controls.Add(this.textBox_InputValue);
            this.panel_Output.Controls.Add(this.vScrollBar_InputValue);
            this.panel_Output.Controls.Add(this.pictureBox_Formula);
            this.panel_Output.Controls.Add(this.label_InputValue);
            this.panel_Output.Location = new System.Drawing.Point(181, 12);
            this.panel_Output.Name = "panel_Output";
            this.panel_Output.Size = new System.Drawing.Size(356, 254);
            this.panel_Output.TabIndex = 0;
            // 
            // label_Output
            // 
            this.label_Output.Location = new System.Drawing.Point(14, 170);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(326, 71);
            this.label_Output.TabIndex = 3;
            this.label_Output.Text = "Расчет по формуле при n = ...";
            this.label_Output.TextChanged += new System.EventHandler(this.label_Output_TextChanged);
            // 
            // textBox_InputValue
            // 
            this.textBox_InputValue.Location = new System.Drawing.Point(87, 142);
            this.textBox_InputValue.Name = "textBox_InputValue";
            this.textBox_InputValue.ReadOnly = true;
            this.textBox_InputValue.Size = new System.Drawing.Size(51, 20);
            this.textBox_InputValue.TabIndex = 2;
            // 
            // vScrollBar_InputValue
            // 
            this.vScrollBar_InputValue.Location = new System.Drawing.Point(141, 137);
            this.vScrollBar_InputValue.Maximum = 50;
            this.vScrollBar_InputValue.Name = "vScrollBar_InputValue";
            this.vScrollBar_InputValue.Size = new System.Drawing.Size(17, 30);
            this.vScrollBar_InputValue.TabIndex = 1;
            this.vScrollBar_InputValue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_InputValue_Scroll);
            // 
            // pictureBox_Formula
            // 
            this.pictureBox_Formula.Image = global::WinFormsApp_ImpUserInterface.Properties.Resources.Task_1;
            this.pictureBox_Formula.Location = new System.Drawing.Point(27, 21);
            this.pictureBox_Formula.Name = "pictureBox_Formula";
            this.pictureBox_Formula.Size = new System.Drawing.Size(300, 100);
            this.pictureBox_Formula.TabIndex = 0;
            this.pictureBox_Formula.TabStop = false;
            // 
            // label_InputValue
            // 
            this.label_InputValue.AutoSize = true;
            this.label_InputValue.Location = new System.Drawing.Point(14, 145);
            this.label_InputValue.Name = "label_InputValue";
            this.label_InputValue.Size = new System.Drawing.Size(67, 13);
            this.label_InputValue.TabIndex = 0;
            this.label_InputValue.Text = "Значение n:";
            // 
            // button_EvaluateVariant
            // 
            this.button_EvaluateVariant.Location = new System.Drawing.Point(11, 93);
            this.button_EvaluateVariant.Name = "button_EvaluateVariant";
            this.button_EvaluateVariant.Size = new System.Drawing.Size(152, 44);
            this.button_EvaluateVariant.TabIndex = 1;
            this.button_EvaluateVariant.Text = "Выполнить расчет";
            this.button_EvaluateVariant.UseVisualStyleBackColor = true;
            this.button_EvaluateVariant.Click += new System.EventHandler(this.button_EvaluateVariant_Click);
            // 
            // button_EvaluateAllDefault
            // 
            this.button_EvaluateAllDefault.Location = new System.Drawing.Point(11, 157);
            this.button_EvaluateAllDefault.Name = "button_EvaluateAllDefault";
            this.button_EvaluateAllDefault.Size = new System.Drawing.Size(152, 44);
            this.button_EvaluateAllDefault.TabIndex = 2;
            this.button_EvaluateAllDefault.Text = "Все расчеты со значениями по умолчанию";
            this.button_EvaluateAllDefault.UseVisualStyleBackColor = true;
            this.button_EvaluateAllDefault.Click += new System.EventHandler(this.button_EvaluateAllDefault_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(12, 222);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(151, 44);
            this.button_Close.TabIndex = 3;
            this.button_Close.Text = "Закрыть";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_InputTaskNum
            // 
            this.label_InputTaskNum.AutoSize = true;
            this.label_InputTaskNum.Location = new System.Drawing.Point(12, 33);
            this.label_InputTaskNum.Name = "label_InputTaskNum";
            this.label_InputTaskNum.Size = new System.Drawing.Size(137, 13);
            this.label_InputTaskNum.TabIndex = 4;
            this.label_InputTaskNum.Text = "Выберите номер задания";
            // 
            // comboBox_TaskNum
            // 
            this.comboBox_TaskNum.FormattingEnabled = true;
            this.comboBox_TaskNum.Items.AddRange(new object[] {
            "«Задание 1»",
            "«Задание 2»",
            "«Задание 3»"});
            this.comboBox_TaskNum.Location = new System.Drawing.Point(15, 49);
            this.comboBox_TaskNum.Name = "comboBox_TaskNum";
            this.comboBox_TaskNum.Size = new System.Drawing.Size(134, 21);
            this.comboBox_TaskNum.TabIndex = 4;
            this.comboBox_TaskNum.SelectedIndexChanged += new System.EventHandler(this.comboBox_TaskNum_SelectedIndexChanged);
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 280);
            this.Controls.Add(this.comboBox_TaskNum);
            this.Controls.Add(this.label_InputTaskNum);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_EvaluateAllDefault);
            this.Controls.Add(this.button_EvaluateVariant);
            this.Controls.Add(this.panel_Output);
            this.Name = "form_Main";
            this.Text = "Выполнение расчетов с помощью пользовательского интерфейса";
            this.Load += new System.EventHandler(this.form_Main_Load);
            this.panel_Output.ResumeLayout(false);
            this.panel_Output.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Formula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Output;
        private System.Windows.Forms.TextBox textBox_InputValue;
        private System.Windows.Forms.VScrollBar vScrollBar_InputValue;
        private System.Windows.Forms.Label label_InputValue;
        private System.Windows.Forms.PictureBox pictureBox_Formula;
        private System.Windows.Forms.Button button_EvaluateVariant;
        private System.Windows.Forms.Button button_EvaluateAllDefault;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.Label label_InputTaskNum;
        private System.Windows.Forms.ComboBox comboBox_TaskNum;
    }
}

