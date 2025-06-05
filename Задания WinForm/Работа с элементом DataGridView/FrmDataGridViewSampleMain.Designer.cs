using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class FrmDataGridViewSampleMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.GroupBoxAddNewBook = new System.Windows.Forms.GroupBox();
            this.ButtonAddBook = new System.Windows.Forms.Button();
            this.DateTimePickerDatePublished = new System.Windows.Forms.DateTimePicker();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TextBoxAuthor = new System.Windows.Forms.TextBox();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.LabelDatePublished = new System.Windows.Forms.Label();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.DataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.ContextMenuStripForGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemRemoveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditBook = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.TextBoxBooks = new System.Windows.Forms.RichTextBox();
            this.GroupBoxAddNewBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBooks)).BeginInit();
            this.ContextMenuStripForGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(12, 15);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(42, 13);
            this.LabelSearch.TabIndex = 0;
            this.LabelSearch.Text = "Поиск:";
            // 
            // GroupBoxAddNewBook
            // 
            this.GroupBoxAddNewBook.Controls.Add(this.ButtonAddBook);
            this.GroupBoxAddNewBook.Controls.Add(this.DateTimePickerDatePublished);
            this.GroupBoxAddNewBook.Controls.Add(this.TextBoxAuthor);
            this.GroupBoxAddNewBook.Controls.Add(this.TextBoxTitle);
            this.GroupBoxAddNewBook.Controls.Add(this.LabelDatePublished);
            this.GroupBoxAddNewBook.Controls.Add(this.LabelAuthor);
            this.GroupBoxAddNewBook.Controls.Add(this.LabelTitle);
            this.GroupBoxAddNewBook.Location = new System.Drawing.Point(12, 435);
            this.GroupBoxAddNewBook.Name = "GroupBoxAddNewBook";
            this.GroupBoxAddNewBook.Size = new System.Drawing.Size(984, 59);
            this.GroupBoxAddNewBook.TabIndex = 1;
            this.GroupBoxAddNewBook.TabStop = false;
            this.GroupBoxAddNewBook.Text = "Добавить новую книгу в коллекцию:";
            // 
            // ButtonAddBook
            // 
            this.ButtonAddBook.Location = new System.Drawing.Point(823, 20);
            this.ButtonAddBook.Name = "ButtonAddBook";
            this.ButtonAddBook.Size = new System.Drawing.Size(147, 23);
            this.ButtonAddBook.TabIndex = 6;
            this.ButtonAddBook.Text = "&Добавить книгу";
            this.ButtonAddBook.UseVisualStyleBackColor = true;
            this.ButtonAddBook.Click += new System.EventHandler(this.ButtonAddBook_Click);
            // 
            // DateTimePickerDatePublished
            // 
            this.DateTimePickerDatePublished.CustomFormat = "yyyy";
            this.DateTimePickerDatePublished.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "DatePublished", true));
            this.DateTimePickerDatePublished.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerDatePublished.Location = new System.Drawing.Point(717, 22);
            this.DateTimePickerDatePublished.Name = "DateTimePickerDatePublished";
            this.DateTimePickerDatePublished.Size = new System.Drawing.Size(66, 20);
            this.DateTimePickerDatePublished.TabIndex = 5;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(WindowsFormsApp1.Book);
            // 
            // TextBoxAuthor
            // 
            this.TextBoxAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
            this.TextBoxAuthor.Location = new System.Drawing.Point(439, 22);
            this.TextBoxAuthor.Name = "TextBoxAuthor";
            this.TextBoxAuthor.Size = new System.Drawing.Size(175, 20);
            this.TextBoxAuthor.TabIndex = 4;
            this.TextBoxAuthor.TextChanged += new System.EventHandler(this.TextBoxAuthor_TextChanged);
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Title", true));
            this.TextBoxTitle.Location = new System.Drawing.Point(82, 22);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(294, 20);
            this.TextBoxTitle.TabIndex = 3;
            this.TextBoxTitle.TextChanged += new System.EventHandler(this.TextBoxTitle_TextChanged);
            // 
            // LabelDatePublished
            // 
            this.LabelDatePublished.AutoSize = true;
            this.LabelDatePublished.Location = new System.Drawing.Point(630, 25);
            this.LabelDatePublished.Name = "LabelDatePublished";
            this.LabelDatePublished.Size = new System.Drawing.Size(73, 13);
            this.LabelDatePublished.TabIndex = 2;
            this.LabelDatePublished.Text = "Год издания:";
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.LabelAuthor.Location = new System.Drawing.Point(393, 25);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(40, 13);
            this.LabelAuthor.TabIndex = 1;
            this.LabelAuthor.Text = "Автор:";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(16, 25);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(60, 13);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Название:";
            // 
            // DataGridViewBooks
            // 
            this.DataGridViewBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBooks.ContextMenuStrip = this.ContextMenuStripForGrid;
            this.DataGridViewBooks.Location = new System.Drawing.Point(12, 38);
            this.DataGridViewBooks.Name = "DataGridViewBooks";
            this.DataGridViewBooks.Size = new System.Drawing.Size(587, 388);
            this.DataGridViewBooks.TabIndex = 0;
            this.DataGridViewBooks.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewBooks_CellEndEdit);
            this.DataGridViewBooks.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridViewBooks_DataError);
            this.DataGridViewBooks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridViewBooks_MouseDown);
            // 
            // ContextMenuStripForGrid
            // 
            this.ContextMenuStripForGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRemoveBook,
            this.MenuItemEditBook});
            this.ContextMenuStripForGrid.Name = "ContextMenuStripForGrid";
            this.ContextMenuStripForGrid.Size = new System.Drawing.Size(257, 48);
            this.ContextMenuStripForGrid.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripForGrid_Opening);
            // 
            // MenuItemRemoveBook
            // 
            this.MenuItemRemoveBook.Name = "MenuItemRemoveBook";
            this.MenuItemRemoveBook.Size = new System.Drawing.Size(256, 22);
            this.MenuItemRemoveBook.Text = "&Удалить выбранную книгу";
            this.MenuItemRemoveBook.Click += new System.EventHandler(this.MenuItemRemoveBook_Click);
            // 
            // MenuItemEditBook
            // 
            this.MenuItemEditBook.Name = "MenuItemEditBook";
            this.MenuItemEditBook.Size = new System.Drawing.Size(256, 22);
            this.MenuItemEditBook.Text = "&Редактировать выбранную книгу";
            this.MenuItemEditBook.Click += new System.EventHandler(this.MenuItemEditBook_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(53, 12);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(546, 20);
            this.TextBoxSearch.TabIndex = 3;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // TextBoxBooks
            // 
            this.TextBoxBooks.Location = new System.Drawing.Point(605, 12);
            this.TextBoxBooks.Name = "TextBoxBooks";
            this.TextBoxBooks.ReadOnly = true;
            this.TextBoxBooks.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextBoxBooks.Size = new System.Drawing.Size(391, 417);
            this.TextBoxBooks.TabIndex = 2;
            this.TextBoxBooks.Text = "";
            // 
            // FrmDataGridViewSampleMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 529);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.TextBoxBooks);
            this.Controls.Add(this.DataGridViewBooks);
            this.Controls.Add(this.GroupBoxAddNewBook);
            this.Controls.Add(this.LabelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDataGridViewSampleMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Allineed.Ru] Пример работы с элементом DataGridView";
            this.Load += new System.EventHandler(this.FrmDataGridViewSampleMain_Load);
            this.GroupBoxAddNewBook.ResumeLayout(false);
            this.GroupBoxAddNewBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBooks)).EndInit();
            this.ContextMenuStripForGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.GroupBox GroupBoxAddNewBook;
        private System.Windows.Forms.DataGridView DataGridViewBooks;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.DateTimePicker DateTimePickerDatePublished;
        private System.Windows.Forms.TextBox TextBoxAuthor;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.Label LabelDatePublished;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.Label LabelTitle;
        private Button ButtonAddBook;
        private ContextMenuStrip ContextMenuStripForGrid;
        private ToolStripMenuItem MenuItemRemoveBook;
        private ToolStripMenuItem MenuItemEditBook;
        private RichTextBox TextBoxBooks;
        private BindingSource bookBindingSource;
    }
}

