using LibraryMgmtSystem.Domain.Entities;
using LibraryMgmtSystem.DTO;
using LibraryMgmtSystem.Infrastructure;
using LibraryMgmtSystem.Presenters;
using LibraryMgmtSystem.Views;

namespace LibraryMgmtSystem
{
    public partial class MainForm : Form, IMainView
    {
        private readonly MainPresenter _presenter;


        public List<BookStatusDto> Books
        {
            set
            {
                dgvBooks.DataSource = value;
            }
        }

        public BookStatusDto SelectedBook
        {
            get
            {
                if (dgvBooks.SelectedRows?.Count > 0)
                {
                    return (BookStatusDto)dgvBooks.SelectedRows[0].DataBoundItem;
                }
                else
                {
                    return null;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();

            _presenter = new MainPresenter(this);
            btnBookAdd.Click += (sender, e) => NewBookClicked?.Invoke(sender, e);
            btnBookEdit.Click += (sender, e) => EditBookClicked?.Invoke(sender, e);
            btnBookDelete.Click += (sender, e) => DeleteBookClicked?.Invoke(sender, e);
            btnBorrowers.Click += (sender, e) => BorrowersClicked?.Invoke(sender, e);
            btnCheckout.Click += (sender, e) => CheckoutClicked?.Invoke(sender, e);
            btnReturn.Click += (sender, e) => ReturnClicked?.Invoke(sender, e);
        }

        public event EventHandler NewBookClicked;
        public event EventHandler EditBookClicked;
        public event EventHandler DeleteBookClicked;
        public event EventHandler BorrowersClicked;
        public event EventHandler CheckoutClicked;
        public event EventHandler ReturnClicked;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
