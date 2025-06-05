using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace DataGridViewSample
{
    public partial class FrmEditBook : Form
    {
    public delegate void DelegateUpdateBook(Book updatedBook);

        public event DelegateUpdateBook BookUpdatedEvent;
        public Book EditedBook { get; set; }
        public FrmEditBook()
        {
            InitializeComponent();
        }
        private void FrmEditBook_Load(object sender, EventArgs e)
        {
            bookBindingSource.Add(EditedBook);
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Book bookUpdated = (Book)bookBindingSource.Current;
if (BookUpdatedEvent != null)
            {
                BookUpdatedEvent(bookUpdated);
            }
            Close();
        }
    }
}
