using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class Members:Users
    {
        public Members()
        {
            MemberId = Guid.NewGuid();
        }
        public enum gender {Woman,Man,NotDefined}
        public Guid MemberId { get; set; }
        public string Name { get; set; }
        public string Fname { get; set; }
        public string NationalCode { get; set; }
        public string Email { get; set; }
        public int Gender { get; set; }
        public string PhoneNumber { get; set; }
        public int NumOfBorrowedBooks { get; set; }
        public string Number { get; set; }
    }
}