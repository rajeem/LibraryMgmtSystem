using LibraryMgmtSystem.Domain.Entities;

namespace LibraryMgmtSystem.Views
{
    public interface IBookView
    {
        Book Book { get; set; }
        DialogResult ShowDialog();
    }
}
