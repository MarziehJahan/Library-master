using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    class BorrowedRepository
    {
        Borrowed borrowed;
        Context context;
        public BorrowedRepository()
        {
            borrowed = new Borrowed();
            context = new Context();
        }
        public void AddToBorrowed(Borrowed borrowed)
        {
            var data = context.borroweds();
            if (data==null)
            {
                data = new List<Borrowed>();
            }
            data.Add(borrowed);
            context.SaveChangesForBorroweds(data);
        }
        public List<Borrowed> GetAllBorroweds()
        {
            try
            {
                return context.borroweds();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Borrowed GetBorrowedByBookCode(Guid code)
        {
            Borrowed borrowed;
            try
            {
                borrowed = GetAllBorroweds().Single(a => a.BookCode == code && a.DeliveryTime==DateTime.MinValue);
            }
            catch (Exception)
            {

                return null;
            }
            return borrowed;
        }
        public void DeliverBookToLib(Guid code,DateTime deliveryTime)
        {
            var data = context.borroweds();
            int tmp = data.FindIndex(a => a.BookCode == code);
            Borrowed borrowed = GetBorrowedByBookCode(code);
            borrowed.DeliveryTime = deliveryTime;
            data[tmp] = borrowed;
            context.SaveChangesForBorroweds(data);
        }
        public List<Borrowed> GetBorrowedsByMemberId(Guid memberId)
        {
            List<Borrowed> borroweds;
            try
            {
                 borroweds = GetAllBorroweds().FindAll(a => a.MemberId == memberId && a.DeliveryTime == DateTime.MinValue);
            }
            catch (Exception)
            {
                borroweds = null;
            }
            return borroweds;
        }
        public bool checkIfBookIsBorrowedByUser(Guid memberId,Guid codeBook)
        {
            try
            {
                bool check;
                check = GetAllBorroweds().Exists(a => a.MemberId == memberId && a.BookCode == codeBook && a.DeliveryTime == DateTime.MinValue);
                return check;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public Borrowed FindReservedBookBycodeAnduser(Guid memberId, Guid codeBook)
        {
            try
            {
                Borrowed borrow;
                borrow = GetAllBorroweds().Single(a => a.MemberId == memberId && a.BookCode == codeBook && a.DeliveryTime == DateTime.MinValue);
                return borrow;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void EvalFine(DateTime date,long value)
        {
            try
            {
                var data = context.borroweds();
                List<Borrowed> borroweds = GetAllBorroweds();
                foreach (var item in borroweds)
                {
                    int daysDiff = (date.Date - item.DeadLineForBorrow.Date).Days;
                    if (item.DeliveryTime == DateTime.MinValue && item.DeadLineForBorrow.Date < date.Date)
                    {
                        item.fines = daysDiff * value;
                    }
                    //if (item.DeliveryTime==DateTime.MinValue && item.DeadLineForBorrow.Date<date.Date)
                    //{
                    //    if (date.Month==item.DeadLineForBorrow.Month)
                    //    {
                    //         fine = (date.Day - item.DeadLineForBorrow.Day) * value;
                    //         item.fines = fine;
                    //         //int tmp1 = data.FindIndex(a => a == item);
                    //         //data[tmp1] = item;
                    //    }
                    //    else if(date.Month>item.DeadLineForBorrow.Month)
                    //    {
                    //        List<int> lastDaysOfMonths = new List<int>();
                    //        for (int i = 0; i < date.Month-item.DeadLineForBorrow.Month; i++)
                    //        {
                    //            if (i==0)
                    //            {
                    //                lastDaysOfMonths.Add(date.Day);
                    //            }
                    //            else
                    //            {
                    //                lastDaysOfMonths.Add(DateTime.DaysInMonth(date.Year, date.Month - i));
                    //            }
                    //        }
                    //        foreach (var day in lastDaysOfMonths)
                    //        {
                    //            fine += day * value;
                    //        }
                    //        fine += (DateTime.DaysInMonth(date.Year, item.DeadLineForBorrow.Month) - item.DeadLineForBorrow.Day) * value;
                    //        item.fines = fine;

                    //    }

                        int tmp = data.FindIndex(a => a.BorrowId==item.BorrowId);
                        data[tmp] = item;
                        context.SaveChangesForBorroweds(data);
                    }
                
                //return fines;
            }
            catch (Exception)
            {
                //return 0;
            }
        }
        public long EvalAllFinesForUser(Guid memberId)
        {
            List<Borrowed> borroweds = GetBorrowedsByMemberId(memberId);
            long AllFines = 0;
            foreach (var item in borroweds)
            {
                AllFines += item.fines;
            }
            return AllFines;
        }
    }
}
