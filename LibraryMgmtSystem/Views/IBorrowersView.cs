using LibraryMgmtSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmtSystem.Views
{
    public enum BorrowersViewMode
    {
        Default,
        Selection
    }

    public interface IBorrowersView
    {
        List<Borrower> Borrowers { set; }
        Borrower SelectedBorrower { get; }
        BorrowersViewMode BorrowersViewMode { set; }
        event EventHandler NewBorrowerClicked;
        event EventHandler EditBorrowerClicked;
        event EventHandler DeleteBorrowerClicked;

        DialogResult ShowDialog();
        void ShowMessage(string message);
    }
}
