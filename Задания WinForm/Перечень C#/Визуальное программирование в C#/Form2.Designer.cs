namespace test
{
    partial class Form2
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
            add_groupBox = new GroupBox();
            second_section_radioButton = new RadioButton();
            first_section_radioButton = new RadioButton();
            type_text_label = new Label();
            textBox = new TextBox();
            add_button = new Button();
            cancel_button = new Button();
            add_groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // add_groupBox
            // 
            add_groupBox.Controls.Add(second_section_radioButton);
            add_groupBox.Controls.Add(first_section_radioButton);
            add_groupBox.Location = new Point(12, 12);
            add_groupBox.Name = "add_groupBox";
            add_groupBox.Size = new Size(274, 77);
            add_groupBox.TabIndex = 0;
            add_groupBox.TabStop = false;
            add_groupBox.Text = "Добавить в";
            // 
            // second_section_radioButton
            // 
            second_section_radioButton.AutoSize = true;
            second_section_radioButton.Location = new Point(6, 47);
            second_section_radioButton.Name = "second_section_radioButton";
            second_section_radioButton.Size = new Size(71, 19);
            second_section_radioButton.TabIndex = 1;
            second_section_radioButton.TabStop = true;
            second_section_radioButton.Text = "Раздел 2";
            second_section_radioButton.UseVisualStyleBackColor = true;
            // 
            // first_section_radioButton
            // 
            first_section_radioButton.AutoSize = true;
            first_section_radioButton.Location = new Point(6, 22);
            first_section_radioButton.Name = "first_section_radioButton";
            first_section_radioButton.Size = new Size(71, 19);
            first_section_radioButton.TabIndex = 0;
            first_section_radioButton.TabStop = true;
            first_section_radioButton.Text = "Раздел 1";
            first_section_radioButton.UseVisualStyleBackColor = true;
            // 
            // type_text_label
            // 
            type_text_label.AutoSize = true;
            type_text_label.Location = new Point(12, 92);
            type_text_label.Name = "type_text_label";
            type_text_label.Size = new Size(84, 15);
            type_text_label.TabIndex = 1;
            type_text_label.Text = "Введите текст:";
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 110);
            textBox.Name = "textBox";
            textBox.Size = new Size(274, 23);
            textBox.TabIndex = 2;
            // 
            // add_button
            // 
            add_button.Location = new Point(12, 138);
            add_button.Name = "add_button";
            add_button.Size = new Size(132, 29);
            add_button.TabIndex = 3;
            add_button.Text = "Добавить";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(150, 138);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(136, 29);
            cancel_button.TabIndex = 4;
            cancel_button.Text = "Отмена";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 176);
            Controls.Add(cancel_button);
            Controls.Add(add_button);
            Controls.Add(textBox);
            Controls.Add(type_text_label);
            Controls.Add(add_groupBox);
            Name = "Form2";
            Text = "Form2";
            add_groupBox.ResumeLayout(false);
            add_groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox add_groupBox;
        private RadioButton second_section_radioButton;
        private RadioButton first_section_radioButton;
        private Label type_text_label;
        private TextBox textBox;
        private Button add_button;
        private Button cancel_button;
    }
}