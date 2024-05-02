using LibraryMgmtSystem.Domain.Entities;
using LibraryMgmtSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmtSystem.Views
{
    public interface IMainView
    {
        List<BookStatusDto> Books { set; }
        BookStatusDto SelectedBook { get; }
        event EventHandler NewBookClicked;
        event EventHandler EditBookClicked;
        event EventHandler DeleteBookClicked;
        event EventHandler BorrowersClicked;
        event EventHandler CheckoutClicked;
        event EventHandler ReturnClicked;

        void ShowMessage(string message);
    }
}
