using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class Borrowed
    {
        public Borrowed()
        {
            BorrowId = Guid.NewGuid();
        }
        public Guid BorrowId { get; set; }
        public Guid MemberId { get; set; }
        public Guid BookCode { get; set; }
        public DateTime TimeOfBorrow { get; set; }
        public DateTime DeliveryTime { get; set; }
        public DateTime DeadLineForBorrow { get; set; }
        public long fines { get; set; }
    }
}
