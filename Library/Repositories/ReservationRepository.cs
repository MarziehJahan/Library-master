using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    class ReservationRepository
    {
        Context context;
        public ReservationRepository()
        {
            context = new Context();
        }
        public void AddToReserved(Reservations reservation)
        {
            var data = context.reservations();
            if (data==null)
            {
                data = new List<Reservations>();
            }
            data.Add(reservation);
            context.SaveChangesForReservations(data);

        }
        public List<Reservations> GetAllReservations()
        {
            return context.reservations().FindAll(a => a.ReservationState == 0);
        }
        public int NumberOfReservations(string nationalCode)
        {
            List<Reservations> foundReserved = new List<Reservations>();
            try
            {
                foundReserved = GetAllReservations().FindAll(a => a.nationalCode == nationalCode);
            }
            catch (Exception)
            {
                foundReserved = null;
            }
            if (foundReserved!=null)
            {
                return foundReserved.Count;
            }
            else
            {
                return 0;
            }
        }
        public bool CheckIfReservationIsRepeating(string nationalCode,Guid bookCode)
        {
            List<Reservations> reserved;
            try
            {
                reserved = GetAllReservations().FindAll(a => a.nationalCode == nationalCode && a.BookCode == bookCode);
            }
            catch (Exception)
            {
                reserved = null;
            }
            if (reserved == null || reserved.Count==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<Reservations> GetAllReservatiosByUser(string nationalCode)
        {
            List<Reservations> reserved = new List<Reservations>();
            try
            {
                reserved = GetAllReservations().FindAll(a => a.nationalCode == nationalCode);
            }
            catch (Exception)
            {
                reserved = null;
            }
            return reserved;
        }
        public bool CheckIfBookIsReservedByUser(string nationalCode, Guid codeBook)
        {
            bool reserved;
            try
            {
                reserved = GetAllReservatiosByUser(nationalCode).Exists(a => a.BookCode == codeBook);
            }
            catch (Exception)
            {
                reserved = false;
            }
            return reserved;
        }

    }
}
