namespace WindowsFormsApp1
{
    partial class FrmListBoxSample
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
            this.ListBoxElements = new System.Windows.Forms.ListBox();
            this.ButtonAddElement = new System.Windows.Forms.Button();
            this.ButtonRemoveSelectedElement = new System.Windows.Forms.Button();
            this.ButtonClearList = new System.Windows.Forms.Button();
            this.TextBoxNewElement = new System.Windows.Forms.TextBox();
            this.TextBoxEvents = new System.Windows.Forms.RichTextBox();
            this.LabelInfoSelectedElement = new System.Windows.Forms.Label();
            this.LabelEvents = new System.Windows.Forms.Label();
            this.LabelInfoSelectedElementContents = new System.Windows.Forms.RichTextBox();
            this.ButtonClearLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxElements
            // 
            this.ListBoxElements.FormattingEnabled = true;
            this.ListBoxElements.Location = new System.Drawing.Point(12, 12);
            this.ListBoxElements.Name = "ListBoxElements";
            this.ListBoxElements.Size = new System.Drawing.Size(247, 394);
            this.ListBoxElements.TabIndex = 0;
            this.ListBoxElements.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxElements_MouseClick);
            this.ListBoxElements.SelectedIndexChanged += new System.EventHandler(this.ListBoxElements_SelectedIndexChanged);
            // 
            // ButtonAddElement
            // 
            this.ButtonAddElement.Location = new System.Drawing.Point(457, 119);
            this.ButtonAddElement.Name = "ButtonAddElement";
            this.ButtonAddElement.Size = new System.Drawing.Size(209, 23);
            this.ButtonAddElement.TabIndex = 1;
            this.ButtonAddElement.Text = "&Добавить элемент в список";
            this.ButtonAddElement.UseVisualStyleBackColor = true;
            this.ButtonAddElement.Click += new System.EventHandler(this.ButtonAddElement_Click);
            // 
            // ButtonRemoveSelectedElement
            // 
            this.ButtonRemoveSelectedElement.Location = new System.Drawing.Point(12, 412);
            this.ButtonRemoveSelectedElement.Name = "ButtonRemoveSelectedElement";
            this.ButtonRemoveSelectedElement.Size = new System.Drawing.Size(247, 23);
            this.ButtonRemoveSelectedElement.TabIndex = 2;
            this.ButtonRemoveSelectedElement.Text = "&Удалить выбранный элемент";
            this.ButtonRemoveSelectedElement.UseVisualStyleBackColor = true;
            this.ButtonRemoveSelectedElement.Click += new System.EventHandler(this.ButtonRemoveSelectedElement_Click);
            // 
            // ButtonClearList
            // 
            this.ButtonClearList.Location = new System.Drawing.Point(12, 441);
            this.ButtonClearList.Name = "ButtonClearList";
            this.ButtonClearList.Size = new System.Drawing.Size(247, 23);
            this.ButtonClearList.TabIndex = 3;
            this.ButtonClearList.Text = "&Очистить список";
            this.ButtonClearList.UseVisualStyleBackColor = true;
            this.ButtonClearList.Click += new System.EventHandler(this.ButtonClearList_Click);
            // 
            // TextBoxNewElement
            // 
            this.TextBoxNewElement.Location = new System.Drawing.Point(274, 93);
            this.TextBoxNewElement.Name = "TextBoxNewElement";
            this.TextBoxNewElement.Size = new System.Drawing.Size(392, 20);
            this.TextBoxNewElement.TabIndex = 4;
            this.TextBoxNewElement.Text = "< Введите текст для элемента списка... >";
            this.TextBoxNewElement.TextChanged += new System.EventHandler(this.TextBoxNewElement_TextChanged);
            this.TextBoxNewElement.Enter += new System.EventHandler(this.TextBoxNewElement_Enter);
            this.TextBoxNewElement.Leave += new System.EventHandler(this.TextBoxNewElement_Leave);
            // 
            // TextBoxEvents
            // 
            this.TextBoxEvents.Location = new System.Drawing.Point(274, 180);
            this.TextBoxEvents.Name = "TextBoxEvents";
            this.TextBoxEvents.ReadOnly = true;
            this.TextBoxEvents.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextBoxEvents.Size = new System.Drawing.Size(392, 226);
            this.TextBoxEvents.TabIndex = 5;
            this.TextBoxEvents.Text = "";
            // 
            // LabelInfoSelectedElement
            // 
            this.LabelInfoSelectedElement.AutoSize = true;
            this.LabelInfoSelectedElement.Location = new System.Drawing.Point(271, 12);
            this.LabelInfoSelectedElement.Name = "LabelInfoSelectedElement";
            this.LabelInfoSelectedElement.Size = new System.Drawing.Size(234, 13);
            this.LabelInfoSelectedElement.TabIndex = 6;
            this.LabelInfoSelectedElement.Text = "Информация о выбранном элементе списка";
            // 
            // LabelEvents
            // 
            this.LabelEvents.AutoSize = true;
            this.LabelEvents.Location = new System.Drawing.Point(271, 151);
            this.LabelEvents.Name = "LabelEvents";
            this.LabelEvents.Size = new System.Drawing.Size(93, 13);
            this.LabelEvents.TabIndex = 7;
            this.LabelEvents.Text = "События списка:";
            // 
            // LabelInfoSelectedElementContents
            // 
            this.LabelInfoSelectedElementContents.Location = new System.Drawing.Point(274, 28);
            this.LabelInfoSelectedElementContents.Name = "LabelInfoSelectedElementContents";
            this.LabelInfoSelectedElementContents.Size = new System.Drawing.Size(392, 46);
            this.LabelInfoSelectedElementContents.TabIndex = 8;
            this.LabelInfoSelectedElementContents.Text = "";
            // 
            // ButtonClearLog
            // 
            this.ButtonClearLog.Location = new System.Drawing.Point(457, 412);
            this.ButtonClearLog.Name = "ButtonClearLog";
            this.ButtonClearLog.Size = new System.Drawing.Size(209, 23);
            this.ButtonClearLog.TabIndex = 9;
            this.ButtonClearLog.Text = "&Очистить лог событий";
            this.ButtonClearLog.UseVisualStyleBackColor = true;
            this.ButtonClearLog.Click += new System.EventHandler(this.ButtonClearLog_Click);
            // 
            // FrmListBoxSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 479);
            this.Controls.Add(this.ButtonClearLog);
            this.Controls.Add(this.LabelInfoSelectedElementContents);
            this.Controls.Add(this.LabelEvents);
            this.Controls.Add(this.LabelInfoSelectedElement);
            this.Controls.Add(this.TextBoxEvents);
            this.Controls.Add(this.TextBoxNewElement);
            this.Controls.Add(this.ButtonClearList);
            this.Controls.Add(this.ButtonRemoveSelectedElement);
            this.Controls.Add(this.ButtonAddElement);
            this.Controls.Add(this.ListBoxElements);
            this.Name = "FrmListBoxSample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Allineed.Ru] Пример работы с элементом ListBox";
            this.Load += new System.EventHandler(this.FrmListBoxSample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxElements;
        private System.Windows.Forms.Button ButtonAddElement;
        private System.Windows.Forms.Button ButtonRemoveSelectedElement;
        private System.Windows.Forms.Button ButtonClearList;
        private System.Windows.Forms.TextBox TextBoxNewElement;
        private System.Windows.Forms.RichTextBox TextBoxEvents;
        private System.Windows.Forms.Label LabelInfoSelectedElement;
        private System.Windows.Forms.Label LabelEvents;
        private System.Windows.Forms.RichTextBox LabelInfoSelectedElementContents;
        private System.Windows.Forms.Button ButtonClearLog;
    }
}

