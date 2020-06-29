using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class Books
    {
        public Books()
        {
            Code = Guid.NewGuid();
        }
        public enum bookCondition {Usable,Lost,Torn,Antiquated}
        public enum bookState {DeliveredToMember,Reserved,AvailableInLibrary}
        public Guid Code { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string AuthorFName { get; set; }
        public string Subject { get; set; }
        public string PublishYear { get; set; }
        public string Price { get; set; }
        public DateTime PurchasedTime { get; set; }
        public int BookCondition { get; set; }
        public int BookState { get; set; }
        public string Explanation { get; set; }
    }
}