using LibraryMgmtSystem.Domain.Entities;
using LibraryMgmtSystem.Views;

namespace LibraryMgmtSystem
{
    public partial class BookForm : Form, IBookView
    {
        private string _bookId {  get; set; }

        public Book Book
        {
            get
            {
                var book = new Book();
                book.Id = _bookId;
                book.Title = txtTitle.Text;
                book.Author = txtAuthor.Text;
                book.Isbn = txtIsbn.Text;

                return book;
            }
            set
            {
                _bookId = value.Id;
                txtTitle.Text = value.Title;
                txtAuthor.Text = value.Author;
                txtIsbn.Text = value.Isbn;
            }
        }

        public BookForm()
        {
            InitializeComponent();
        }
    }
}
