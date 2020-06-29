using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class UserPage : Form
    {
        BooksRepository booksRepo;
        MembersRepository membersRepo;
        Reservations reservation;
        ReservationRepository reservationRepo;
        BorrowedRepository borrowedRepo;
        public UserPage(string userName)
        {
            InitializeComponent();
            booksRepo = new BooksRepository();
            membersRepo = new MembersRepository();
            reservationRepo = new ReservationRepository();
            borrowedRepo = new BorrowedRepository();
            lblUser.Text = userName;

        }
        public void UpdateGrid()
        {
            dataGridOfBooks.ClearSelection();
        }
        private void SearchStorageByAuthor_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "جستجو بر اساس پدید آور";
            btnSearch.Click += BtnSearch_Click;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            UpdateGrid();
            try
            {
                var foundBooks = booksRepo.SearchBooksByAuthorName(txtSearch.Text);
                var founds = booksRepo.SearchBooksByAuthorFname(txtSearch.Text);
                if (founds != null)
                {
                    foreach (var item in founds)
                    {
                        foreach (var a in foundBooks)
                        {
                            if (item.Code != a.Code)
                            {
                                foundBooks.Add(item);
                            }
                        }

                    }
                    var results = (from a in foundBooks
                                   select new
                                   {
                                       نام = a.AuthorName + "  " + a.AuthorFName,
                                       موضوع = a.Subject,
                                       سال = a.PublishYear,
                                       عنوان = a.Title,
                                       قیمت = a.Price,
                                       کدکتاب = a.Code
                                   }).ToList();
                    dataGridOfBooks.DataSource = results;
                }
            }
            catch (Exception)
            {

                
            }
            


        }

        private void SearchStorageBySubject_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "جستجو بر اساس موضوع";
            btnSearch.Click += BtnSearch_Click1;
        }

        private void BtnSearch_Click1(object sender, EventArgs e)
        {
            UpdateGrid();
            var foundBooks = booksRepo.SearchBooksBySubject(txtSearch.Text);
            try
            {
                var results = (from a in foundBooks
                               select new
                               {
                                   نام = a.AuthorName + "  " + a.AuthorFName,
                                   موضوع = a.Subject,
                                   سال = a.PublishYear,
                                   عنوان = a.Title,
                                   قیمت = a.Price,
                                   کدکتاب = a.Code
                               }).ToList();
                dataGridOfBooks.DataSource = results;
            }
            catch (Exception)
            {

            }

        }

        private void SearchStorageByPublishYear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "جستجو بر اساس سال انتشار";
            btnSearch.Click += BtnSearch_Click2;
        }

        private void BtnSearch_Click2(object sender, EventArgs e)
        {
            UpdateGrid();
            try
            {
                var foundBooks = booksRepo.SearchBooksByPublishedYear(txtSearch.Text);
                var results = (from a in foundBooks
                               select new
                               {
                                   نام = a.AuthorName + "  " + a.AuthorFName,
                                   موضوع = a.Subject,
                                   سال = a.PublishYear,
                                   عنوان = a.Title,
                                   قیمت = a.Price,
                                   کدکتاب = a.Code
                               }).ToList();
                dataGridOfBooks.DataSource = results;
            }
            catch (Exception)
            {

            }

        }

        private void SearchStorageByTitle_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "جستجو بر اساس عنوان کتاب";
            btnSearch.Click += BtnSearch_Click3;
        }

        private void BtnSearch_Click3(object sender, EventArgs e)
        {
            UpdateGrid();
            try
            {
                var foundBooks = booksRepo.SearchBooksByTitle(txtSearch.Text);
                var results = (from a in foundBooks
                               select new
                               {
                                   نام = a.AuthorName + "  " + a.AuthorFName,
                                   موضوع = a.Subject,
                                   سال = a.PublishYear,
                                   عنوان = a.Title,
                                   قیمت = a.Price,
                                   کدکتاب = a.Code
                               }).ToList();
                dataGridOfBooks.DataSource = results;
            }
            catch (Exception)
            {

            }

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                string Selected = "";
                Guid codeBook = new Guid();
                var user = membersRepo.FindUserByUserName(lblUser.Text);
                Int32 cnt = dataGridOfBooks.Columns.GetColumnCount(DataGridViewElementStates.Displayed);
                if (cnt<6)
                {
                    MessageBox.Show("کتاب را از قسمت درستی انتخاب نمایید", "خطا");
                   
                }
                else
                {
                    foreach (DataGridViewRow item in dataGridOfBooks.SelectedRows)
                    {


                        Selected = item.Cells[5].Value.ToString();


                    }
                }
                if (dataGridOfBooks.SelectedRows.Count == 0)
                {
                    MessageBox.Show("کتابی جهت رزرو ثبت نشده است. لطفا روی خط رکورد کتاب دلخواه خود کلیک نمایید و سپس دکمه تایید را فشار دهید ", "هشدار");
                }
                else if (reservationRepo.NumberOfReservations(user.NationalCode) == 2)
                {
                    MessageBox.Show("حد مجاز رزرو 2 کتاب می باشد", "اخطار");
                }
                else if (reservationRepo.CheckIfReservationIsRepeating(user.NationalCode, codeBook))
                {
                    MessageBox.Show("شما این کتاب را قبلا رزرو نموده اید", "هشدار");
                }
                else
                {
                    var EndTime = DateTime.Now;
                    codeBook = Guid.Parse(Selected);
                    EndTime = new DateTime(EndTime.Year, EndTime.Month, EndTime.Day + 15);
                    reservation = new Reservations()
                    {
                        ReservedTime = DateTime.Now,
                        nationalCode = user.NationalCode,
                        ReservationState = 0,
                        BookCode = codeBook
                    };
                    reservationRepo.AddToReserved(reservation);
                    booksRepo.ChangeBookState(codeBook, 1);
                    MessageBox.Show("رزرو شما ثبت گردید");
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void ReservedBooks_Click(object sender, EventArgs e)
        {
            UpdateGrid();
            var user = membersRepo.FindUserByUserName(lblUser.Text);
            List<Reservations> foundBooksReserved = new List<Reservations>();
            foundBooksReserved = reservationRepo.GetAllReservatiosByUser(user.NationalCode);
            List<Books> foundBooks = new List<Books>();
            try
            {
                foreach (var item in foundBooksReserved)
                {
                    foundBooks.Add(booksRepo.FindBookByCode(item.BookCode));
                }
            }
            catch (Exception)
            {
                //foundBooks = null;
            }
            var results = (from a in foundBooks
                           select new
                           {
                               نام = a.AuthorName + "  " + a.AuthorFName,
                               موضوع = a.Subject,
                               عنوان = a.Title,
                               کدکتاب = a.Code
                           }).ToList();
            dataGridOfBooks.DataSource = results;
        }

        private void BorrowedBooks_Click(object sender, EventArgs e)
        {
            UpdateGrid();
            var user = membersRepo.FindUserByUserName(lblUser.Text);
            List<Borrowed> foundBorrowedBooks = new List<Borrowed>();
            foundBorrowedBooks = borrowedRepo.GetBorrowedsByMemberId(user.MemberId);
            List<Books> foundBooks = new List<Books>();
            try
            {
                foreach (var item in foundBorrowedBooks)
                {
                    foundBooks.Add(booksRepo.FindBookByCode(item.BookCode));
                }
            }
            catch (Exception)
            {
                //foundBooks = null;
            }
            var results = (from a in foundBooks
                           select new
                           {
                               نام = a.AuthorName + "  " + a.AuthorFName,
                               موضوع = a.Subject,
                               عنوان = a.Title,
                               کدکتاب = a.Code
                           }).ToList();
            dataGridOfBooks.DataSource = results;

        }

        private void Fines_Click(object sender, EventArgs e)
        {
            try
            {
                List<Borrowed> borroweds = borrowedRepo.GetAllBorroweds();
                DateTime now = DateTime.Now;
                long value = 10000;
                foreach (var item in borroweds)
                {
                    //item.fines =
                    borrowedRepo.EvalFine(now, value);
                }
                List<Members> members = new List<Members>();
                members.Add(membersRepo.FindUserByUserName(lblUser.Text));
                var results = (from book in borroweds
                               join member in members on book.MemberId equals member.MemberId
                               select new
                               {
                                   کدملی = member.NationalCode,
                                   جریمه = book.fines
                               }).ToList();
                dataGridOfBooks.DataSource = results;
            }
            catch (Exception)
            {
            }
        }

        private void btnExtendReserve_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridOfBooks.SelectedRows.Count != 1)
                {
                    MessageBox.Show("لطفا کتاب مورد نظر را انتخاب کنید", "خطا");
                }
                else
                {
                    string Selected = "";
                    foreach (DataGridViewRow item in dataGridOfBooks.SelectedRows)
                    {
                        Selected = item.Cells[3].Value.ToString();
                    }
                    Guid codeBook = Guid.Parse(Selected);
                    var book = booksRepo.FindBookByCode(codeBook);
                    var user = membersRepo.FindUserByUserName(lblUser.Text);
                    bool checkReserved = borrowedRepo.checkIfBookIsBorrowedByUser(user.MemberId, book.Code);
                    if (book.BookState != 0 && !checkReserved)
                    {
                        MessageBox.Show("کتاب جزو کتاب های امانت گرفته شده توسط شما نمیباشد", "خطا");
                    }
                    else
                    {
                        var foundBorrowedBooks = borrowedRepo.FindReservedBookBycodeAnduser(user.MemberId, book.Code);
                        borrowedRepo.DeliverBookToLib(book.Code, DateTime.Now);
                        var deadLine = foundBorrowedBooks.DeadLineForBorrow;
                        var lastDayOfMonth = DateTime.DaysInMonth(deadLine.Year, deadLine.Month);
                        if (deadLine.Day + 10 > lastDayOfMonth)
                        {
                            deadLine = new DateTime(deadLine.Year, deadLine.Month + 1, 10 - (lastDayOfMonth - deadLine.Day));
                        }
                        else
                        {
                            deadLine = new DateTime(deadLine.Year, deadLine.Month, deadLine.Day + 10);
                        }

                        Borrowed borrowed = new Borrowed()
                        {
                            BookCode = book.Code,
                            TimeOfBorrow = DateTime.Now,
                            MemberId = user.MemberId,
                            DeadLineForBorrow = deadLine
                        };
                        borrowedRepo.AddToBorrowed(borrowed);
                        MessageBox.Show("تمدید ثبت شد", "Success");

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("لطفا کتاب مورد نظر را از امانات انتخاب کنید", "خطا");
            }
        }

        private void btnAllFines_Click(object sender, EventArgs e)
        {
            var user = membersRepo.FindUserByUserName(lblUser.Text);
            long AllFines = borrowedRepo.EvalAllFinesForUser(user.MemberId);
            MessageBox.Show("مبلغ کل = " + AllFines, "مبلغ کل جریمه ها");
        }
    }
}
