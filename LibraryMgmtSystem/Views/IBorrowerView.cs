using LibraryMgmtSystem.Domain.Entities;

namespace LibraryMgmtSystem.Views
{
    public interface IBorrowerView
    {
        Borrower Borrower { get; set; }
        DialogResult ShowDialog();
    }
}
