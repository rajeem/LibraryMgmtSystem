using LibraryMgmtSystem.Domain.Entities;
using LibraryMgmtSystem.Infrastructure;
using LibraryMgmtSystem.Views;

namespace LibraryMgmtSystem.Presenters
{
    public class BorrowersPresenter
    {
        private readonly IBorrowersView _borrowersView;
        private IBorrowerView _borrowerView;
        private FlatFileRepository _repo;

        public BorrowersPresenter(IBorrowersView view)
        {
            _borrowersView = view;
            _borrowersView.NewBorrowerClicked += NewBorrowerClicked;
            _borrowersView.EditBorrowerClicked += EditBorrowerClicked;
            _borrowersView.DeleteBorrowerClicked += DeleteBorrowerClicked;

            _borrowerView = new BorrowerForm();

            _repo = new FlatFileRepository();
            _borrowersView.Borrowers = _repo.GetAll<Borrower>();
        }

        private void NewBorrowerClicked(object? sender, EventArgs e)
        {
            _borrowerView.Borrower = new Borrower();
            if (_borrowerView.ShowDialog() == DialogResult.OK)
            {
                _repo.Add(_borrowerView.Borrower);
                _borrowersView.Borrowers = _repo.GetAll<Borrower>();
            }
        }

        private void EditBorrowerClicked(object? sender, EventArgs e)
        {
            if (_borrowersView.SelectedBorrower != null)
            {
                _borrowerView.Borrower = _borrowersView.SelectedBorrower;
                if (_borrowerView.ShowDialog() == DialogResult.OK)
                {
                    _repo.Update(_borrowerView.Borrower);
                    _borrowersView.Borrowers = _repo.GetAll<Borrower>();
                }
            }
        }

        private void DeleteBorrowerClicked(object? sender, EventArgs e)
        {
            if (_borrowersView.SelectedBorrower != null)
            {
                _repo.Delete<Borrower>(_borrowersView.SelectedBorrower.Id);
                _borrowersView.Borrowers = _repo.GetAll<Borrower>();
                _borrowersView.ShowMessage("Book deleted");
            }
        }
    }
}
