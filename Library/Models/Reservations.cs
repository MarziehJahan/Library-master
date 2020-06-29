using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class Reservations
    {
        public enum reserveState {reserved,cancelled,borrowed}
        public string nationalCode { get; set; }
        public Guid BookCode { get; set; }
        public DateTime ReservedTime { get; set; }
        public int ReservationState { get; set; }
    }
}
