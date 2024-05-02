using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmtSystem.Domain.Entities
{
    public class LoanTransaction : Entity
    {
        public string BookId { get; set; }
        public string BorrowerId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
