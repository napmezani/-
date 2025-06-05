using DataGridViewSample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmDataGridViewSampleMain : Form
    {
        private List<Book> books = new List<Book>();
        private void InitTestBooksData()
        {
            books.Add(new Book("Война и мир", "Лев Николаевич Толстой",
            DateTime.Parse("1867-01-01")));
            books.Add(new Book("Анна Каренина", "Лев Николаевич Толстой",
            DateTime.Parse("1877-01-01")));
            books.Add(new Book("После бала", "Лев Николаевич Толстой",
            DateTime.Parse("1911-01-01")));
            books.Add(new Book("Юность", "Лев Николаевич Толстой",
            DateTime.Parse("1857-01-01")));
            books.Add(new Book("Кавказский пленник", "Лев Николаевич Толстой", 
            DateTime.Parse("1872 - 01 - 01")));
            books.Add(new Book("Преступление и наказание", "Фёдор Михайлович Достоевский", 
            DateTime.Parse("1866 - 01 - 01")));
            books.Add(new Book("Евгений Онегин", "Александр Сергеевич Пушкин", 
            DateTime.Parse("1833 - 01 - 01")));
            books.Add(new Book("Капитанская дочка", "Александр Сергеевич Пушкин", 
            DateTime.Parse("1836 - 01 - 01")));
            books.Add(new Book("Руслан и Людмила", "Александр Сергеевич Пушкин", 
            DateTime.Parse("1820 - 01 - 01")));
            books.Add(new Book("Метель", "Александр Сергеевич Пушкин",
            DateTime.Parse("1831-01-01")));
            books.Add(new Book("Пиковая дама", "Александр Сергеевич Пушкин",
            DateTime.Parse("1834-01-01")));
            books.Add(new Book("Мать", "Максим Горький",
            DateTime.Parse("1906-01-01")));
            books.Add(new Book("Мёртвые души", "Николай Васильевич Гоголь",
            DateTime.Parse("1842-01-01")));
            books.Add(new Book("Шинель", "Николай Васильевич Гоголь",
            DateTime.Parse("1842-01-01")));
            books.Add(new Book("Тарас Бульба", "Николай Васильевич Гоголь",
            DateTime.Parse("1835-01-01")));
            books.Add(new Book("Нос", "Николай Васильевич Гоголь",
            DateTime.Parse("1836-01-01")));
            books.Add(new Book("Вечера на хуторе близ Диканьки", "Николай Васильевич Гоголь", 
            DateTime.Parse("1830 - 01 - 01")));
            books.Add(new Book("Ночь перед рождеством", "Николай Васильевич Гоголь", 
            DateTime.Parse("1832 - 01 - 01")));
            books.Add(new Book("Вий", "Николай Васильевич Гоголь",
            DateTime.Parse("1835-01-01")));
            books.Add(new Book("Повесть о капитане Копейкине", "Николай Васильевич Гоголь", 
            DateTime.Parse("1842 - 01 - 01")));
            books.Add(new Book("Заколдованное место", "Николай Васильевич Гоголь", 
            DateTime.Parse("1832 - 01 - 01")));
            books.Add(new Book("Портрет", "Николай Васильевич Гоголь",
            DateTime.Parse("1835-01-01")));
            books.Add(new Book("Тихий Дон", "Михаил Александрович Шолохов",
            DateTime.Parse("1928-01-01")));
        }
        private List<Book> GetFilteredBooks()
        {
            List<Book> result = new List<Book>();

            string searchString = TextBoxSearch.Text;
            if (searchString.Length == 0)
            {
                return books;
            }
            searchString = searchString.ToLower();
            foreach (Book book in books)
            {
                if ((book.Title.Length > 0 &&
               book.Title.ToLower().Contains(searchString)) ||
                (book.Author.Length > 0 &&
               book.Author.ToLower().Contains(searchString)) ||
                (book.YearPublished.Length > 0 &&
               book.YearPublished.Contains(searchString)))
                {
                    result.Add(book);
                }
            }
            return result;
        }

        private void RefreshDataGridView()
        {
            DataGridViewBooks.DataSource = null;
            DataGridViewBooks.DataSource = GetFilteredBooks();

            DataGridViewBooks.Columns["Title"].HeaderText = "Название";
            DataGridViewBooks.Columns["Title"].Width = 200;

            DataGridViewBooks.Columns["Author"].HeaderText = "Автор";
            DataGridViewBooks.Columns["Author"].Width = 200;

            DataGridViewBooks.Columns["DatePublished"].HeaderText = "Дата издания";
            DataGridViewBooks.Columns["DatePublished"].Width = 200;
            DataGridViewBooks.Columns["DatePublished"].Visible = false;

            DataGridViewBooks.Columns["YearPublished"].HeaderText = "Год публикации";
            DataGridViewBooks.Columns["YearPublished"].Width = 126;
        }


        private bool cancelContextMenu = false;
        private void UpdateBooksListDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Books: [\r\n");
            foreach (Book b in books)
            {
                sb.Append(b.ToString());
                sb.Append("\r\n");
            }
            sb.Append("]");
            TextBoxBooks.Text = sb.ToString();
        }
        private void RefreshGridAndBookDetails()
        {
            RefreshDataGridView();
            UpdateBooksListDetails();
        }
        private void UpdateButtonAddBookState()
        {
            ButtonAddBook.Enabled = TextBoxTitle.Text.Length > 0 &&
           TextBoxAuthor.Text.Length > 0;
        }


        public FrmDataGridViewSampleMain()
        {

            InitializeComponent();
        }

        private void FrmDataGridViewSampleMain_Load(object sender, EventArgs e)
        {
            InitTestBooksData();
            RefreshGridAndBookDetails();
            UpdateButtonAddBookState();
        }

        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DateTimePickerDatePublished.Value;
            DateTime truncatedDate = DateTime.Parse(selectedDate.ToString("dd.MM.yyyy"));
            Book newBook = new Book(TextBoxTitle.Text, TextBoxAuthor.Text, truncatedDate);
            books.Add(newBook);
            RefreshGridAndBookDetails();
            TextBoxTitle.Text = "";
            TextBoxAuthor.Text = "";
            DateTimePickerDatePublished.Value = DateTime.Now;
            TextBoxTitle.Focus();
        }

        private void DataGridViewBooks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            DataGridViewCell cell = DataGridViewBooks[col, row];
            object cellValue = cell.Value;
            Book book = books[row];
            switch (col)
            {
                case 0:
                    book.Title = (string)cellValue;
                    break;
                case 1:
                    book.Author = (string)cellValue;
                    break;
                case 2:
                    book.DatePublished = (DateTime)cellValue;
                    break;
            }
            UpdateBooksListDetails();
        }

        private void DataGridViewBooks_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            object editedValue = DataGridViewBooks[col, row].EditedFormattedValue;
            if (e.Exception is FormatException fe && col == 2)
            {
                MessageBox.Show("Введите корректную дату, т.к. значение '" + editedValue.ToString() + "' не является датой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
        private void DataGridViewBooks_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = DataGridViewBooks.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0 && hitTestInfo.ColumnIndex >= 0)
                {
                    DataGridViewBooks.ClearSelection();
                    DataGridViewBooks.Rows[hitTestInfo.RowIndex].Selected = true;
                    cancelContextMenu = false;
                }
                else
                {
                    cancelContextMenu = true;
                }
            }
        }

        private void ContextMenuStripForGrid_Opening(object sender, CancelEventArgs e)
        {
            if (cancelContextMenu) e.Cancel = true;
        }

        private void MenuItemRemoveBook_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = DataGridViewBooks.SelectedRows;
            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndex = selectedRow.Index;

                if (rowIndex < 0)
                {
                    continue;
                }

                Book book = books[rowIndex];

                DialogResult dlgConfirm = MessageBox.Show("Удалить эту книгу?\r\n\r\nАвтор: " + book.Author + "\r\nНазвание: " + book.Title + "\r\nГод публикации: " + book.YearPublished, "Подтвердите", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dlgConfirm == DialogResult.Yes)
                {
                    books.RemoveAt(rowIndex);
                }
            }

            RefreshGridAndBookDetails();
        }

        private void MenuItemEditBook_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = DataGridViewBooks.SelectedRows;

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndex = selectedRow.Index;

                if (rowIndex < 0)
                {
                    continue;
                }

                Book book = books[rowIndex];

                FrmEditBook frmEdit = new FrmEditBook();
                frmEdit.EditedBook = book;
                frmEdit.BookUpdatedEvent += FrmEdit_BookUpdatedEvent;
                frmEdit.Show();
            }
        }

        private void FrmEdit_BookUpdatedEvent(Book updatedBook)
        {
            RefreshGridAndBookDetails();
        }

        private void TextBoxTitle_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddBookState();
        }

        private void TextBoxAuthor_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddBookState();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddBookState();
        }
    }
}
