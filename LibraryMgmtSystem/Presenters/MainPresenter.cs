using LibraryMgmtSystem.Domain.Entities;
using LibraryMgmtSystem.DTO;
using LibraryMgmtSystem.Infrastructure;
using LibraryMgmtSystem.Views;

namespace LibraryMgmtSystem.Presenters
{
    public class MainPresenter
    {
        private IMainView _mainView;
        private IBookView _bookView;
        private IBorrowersView _borrowersView;
        private FlatFileRepository _repo;

        public MainPresenter(IMainView view)
        {
            _mainView = view;
            _mainView.NewBookClicked += NewBookClicked;
            _mainView.EditBookClicked += EditBookClicked;
            _mainView.DeleteBookClicked += DeleteBookClicked;
            _mainView.BorrowersClicked += BorrowersClicked;
            _mainView.CheckoutClicked += CheckoutClicked;
            _mainView.ReturnClicked += ReturnClicked;

            _bookView = new BookForm();
            _borrowersView = new BorrowersForm();

            _repo = new FlatFileRepository();
            _mainView.Books = GetBookStatuses();
        }

        private void ReturnClicked(object? sender, EventArgs e)
        {
            if (_mainView.SelectedBook?.TransactionId != null)
            {
                var trans = _repo.Get<LoanTransaction>(_mainView.SelectedBook.TransactionId);
                if (trans != null)
                {
                    trans.ReturnDate = DateTime.Now;
                    _repo.Update(trans);
                    _mainView.Books = GetBookStatuses();
                }
            }
        }

        private void CheckoutClicked(object? sender, EventArgs e)
        {
            _borrowersView = new BorrowersForm();
            _borrowersView.BorrowersViewMode = BorrowersViewMode.Selection;
            _borrowersView.Borrowers = _repo.GetAll<Borrower>();
            if (_borrowersView.ShowDialog() == DialogResult.OK)
            {
                if (_mainView.SelectedBook != null && _borrowersView.SelectedBorrower != null)
                {
                    _repo.Add(new LoanTransaction
                    {
                        Id = Guid.NewGuid().ToString(),
                        BookId = _mainView.SelectedBook.Id,
                        ReturnDate = null,
                        TransactionDate = DateTime.Now,
                        BorrowerId = _borrowersView.SelectedBorrower.Id
                    });

                    _mainView.Books = GetBookStatuses();
                }
            }
        }

        private void BorrowersClicked(object? sender, EventArgs e)
        {
            _borrowersView.Borrowers = _repo.GetAll<Borrower>();
            _borrowersView.ShowDialog();
        }

        private void NewBookClicked(object? sender, EventArgs e)
        {
            _bookView.Book = new Book() { Id = Guid.NewGuid().ToString() };
            if (_bookView.ShowDialog() == DialogResult.OK)
            {
                _repo.Add(_bookView.Book);
                _mainView.Books = GetBookStatuses();
            }
        }

        private void DeleteBookClicked(object? sender, EventArgs e)
        {
            if (_mainView.SelectedBook != null)
            {
                _repo.Delete<Book>(_mainView.SelectedBook.Id);
                _mainView.Books = GetBookStatuses();
                _mainView.ShowMessage("Book deleted");
            }
        }

        private void EditBookClicked(object? sender, EventArgs e)
        {
            if (_mainView.SelectedBook != null)
            {
                _bookView.Book = new Book
                {
                    Id = _mainView.SelectedBook.Id,
                    Author = _mainView.SelectedBook.Author,
                    Isbn = _mainView.SelectedBook.Isbn,
                    Title = _mainView.SelectedBook.Title
                };

                if (_bookView.ShowDialog() == DialogResult.OK)
                {
                    _repo.Update(_bookView.Book);
                    _mainView.Books = GetBookStatuses();
                }
            }
        }

        private List<BookStatusDto> GetBookStatuses()
        {
            var books = _repo.GetAll<Book>().Select(x => new BookStatusDto
            {
                Title = x.Title,
                Author = x.Author,
                Id = x.Id,
                Isbn = x.Isbn,
                Status = "Available"
            }).ToList();
            
            var outstandingLoans = _repo.GetAll<LoanTransaction>().Where(x => x.ReturnDate == null);
            foreach (var loan in outstandingLoans)
            {
                var book = books.SingleOrDefault(x => x.Id == loan.BookId);
                if (book != null)
                {
                    book.TransactionId = loan.Id;
                    if (loan.TransactionDate.AddDays(15) < DateTime.Now)
                    {
                        book.Status = "Borrowed - Overdue";
                    }
                    else
                    {
                        book.Status = "Borrowed";
                    }
                }
            }

            return books;
        }
    }
}
