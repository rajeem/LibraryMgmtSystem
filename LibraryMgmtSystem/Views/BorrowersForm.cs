using LibraryMgmtSystem.Domain.Entities;
using LibraryMgmtSystem.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMgmtSystem.Views
{
    public partial class BorrowersForm : Form, IBorrowersView
    {
        private BorrowersPresenter presenter;

        public List<Borrower> Borrowers
        {
            set
            {
                dgvBorrowers.DataSource = value;
            }
        }

        public Borrower SelectedBorrower
        {
            get
            {
                if (dgvBorrowers.SelectedRows?.Count > 0)
                {
                    return (Borrower)dgvBorrowers.SelectedRows[0].DataBoundItem;
                }
                else
                {
                    return null;
                }
            }
        }

        public BorrowersViewMode BorrowersViewMode
        {
            set
            {
                switch (value)
                {
                    case BorrowersViewMode.Default:
                        btnAddBorrower.Visible = true;
                        btnDeleteBorrower.Visible = true;
                        btnEditBorrower.Visible = true;
                        btnSelect.Visible = false;
                        break;
                    case BorrowersViewMode.Selection:
                        btnAddBorrower.Visible = false;
                        btnDeleteBorrower.Visible = false;
                        btnEditBorrower.Visible = false;
                        btnSelect.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public BorrowersForm(BorrowersViewMode borrowersViewMode = BorrowersViewMode.Default)
        {
            InitializeComponent();

            presenter = new BorrowersPresenter(this);
            btnAddBorrower.Click += (sender, e) => NewBorrowerClicked?.Invoke(sender, e);
            btnEditBorrower.Click += (sender, e) => EditBorrowerClicked?.Invoke(sender, e);
            btnDeleteBorrower.Click += (sender, e) => DeleteBorrowerClicked?.Invoke(sender, e);
        }

        public event EventHandler NewBorrowerClicked;
        public event EventHandler EditBorrowerClicked;
        public event EventHandler DeleteBorrowerClicked;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
