using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class StorageOfBooks : Form
    {
        BooksRepository booksRepo;
        MembersRepository membersRepo;
        Borrowed borrowed;
        BorrowedRepository borrowedRepo;
        ReservationRepository reservationRepo;
        Context context;
        public StorageOfBooks()
        {
            InitializeComponent();
            context = new Context();
            booksRepo = new BooksRepository();
            membersRepo = new MembersRepository();
            borrowedRepo = new BorrowedRepository();
            reservationRepo = new ReservationRepository();
        }
        public void UpdateGrid()
        {
            dataGridStorageOfBooks.DataSource = null;
            
        }
        private void SearchStorageByAuthor_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "جستجو بر اساس پدید آور";
            btnSearch.Click += BtnSearch_Click;
            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var foundBooks = booksRepo.SearchBooksByAuthorName(txtSearch.Text);
                var founds = booksRepo.SearchBooksByAuthorFname(txtSearch.Text);
                foreach (var item in founds)
                {
                    foreach (var a in foundBooks)
                    {
                        if (a.Code!=item.Code)
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
                                   خریدکتاب = a.PurchasedTime,
                                   کدکتاب=a.Code
                               }).ToList();
                dataGridStorageOfBooks.DataSource = results;
            }
            catch (Exception)
            {
               // UpdateGrid();
            }
            
        }
        private void SearchStorageBySubject_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "جستجو بر اساس موضوع";
            btnSearch.Click += BtnSearch_Click1;
        }

        private void BtnSearch_Click1(object sender, EventArgs e)
        {
            try
            {
                var foundBooks = booksRepo.SearchBooksBySubject(txtSearch.Text);
                var results = (from a in foundBooks
                               select new
                               {
                                   نام = a.AuthorName + "  " + a.AuthorFName,
                                   موضوع = a.Subject,
                                   سال = a.PublishYear,
                                   عنوان = a.Title,
                                   قیمت = a.Price,
                                   خریدکتاب = a.PurchasedTime,
                                   کدکتاب = a.Code
                               }).ToList();
                dataGridStorageOfBooks.DataSource = results;

            }
            catch (Exception)
            {
                //UpdateGrid();
            }
           
        }

        private void SearchStorageByPublishYear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "جستجو بر اساس سال انتشار";
            btnSearch.Click += BtnSearch_Click2;
        }

        private void BtnSearch_Click2(object sender, EventArgs e)
        {
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
                                   خریدکتاب = a.PurchasedTime,
                                   کدکتاب = a.Code
                               }).ToList();
                dataGridStorageOfBooks.DataSource = results;
            }
            catch (Exception)
            {
                //UpdateGrid();
            }
            

        }
        private void SaveNewBook_Click(object sender, EventArgs e)
        {
            var th = new Thread(() =>Application.Run(new SaveNewBooks()));
            th.Start();
        }

        private void SearchByTitle_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "جستجو بر اساس عنوان کتاب";
            btnSearch.Click += BtnSearch_Click3;
        }

        private void BtnSearch_Click3(object sender, EventArgs e)
        {
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
                                   خریدکتاب = a.PurchasedTime,
                                   کدکتاب = a.Code
                               }).ToList();
                dataGridStorageOfBooks.DataSource = results;
            }
            catch (Exception)
            {
                //UpdateGrid();
            }
            
        }

        private void MissedBooks_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateGrid();
                var foundBooks = booksRepo.MissedBooks();
                var results = (from a in foundBooks
                               select new
                               {
                                   نام = a.AuthorName + "  " + a.AuthorFName,
                                   موضوع = a.Subject,
                                   سال = a.PublishYear,
                                   عنوان = a.Title,
                                   قیمت = a.Price,
                                   خریدکتاب = a.PurchasedTime,
                                   کدکتاب = a.Code
                               }).ToList();
                dataGridStorageOfBooks.DataSource = results;
            }
            catch (Exception)
            {
                UpdateGrid();
            }
            
        }

        private void MatteredBooks_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateGrid();
                var foundBooks = booksRepo.MatteredBooks();
                var results = (from a in foundBooks
                               select new
                               {
                                   نام = a.AuthorName + "  " + a.AuthorFName,
                                   موضوع = a.Subject,
                                   سال = a.PublishYear,
                                   عنوان = a.Title,
                                   قیمت = a.Price,
                                   خریدکتاب = a.PurchasedTime,
                                   کدکتاب = a.Code
                               }).ToList();
                dataGridStorageOfBooks.DataSource = results;
            }
            catch (Exception)
            {
                UpdateGrid();
            }
            
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                var userNationalCode = txtNationalCode.Text.Replace(" ", "");
                Members member = membersRepo.FindUserByNationalCode(userNationalCode);
                if (member == null)
                {
                    MessageBox.Show("عضوی با این کد ملی یافت نشد", "خطا");
                }
                if (dataGridStorageOfBooks.SelectedRows.Count != 1 || userNationalCode == "")
                {
                    MessageBox.Show("لطفا کتاب و کاربر را انتخاب کنید", "خطا");
                }
                else
                {
                    string Selected = "";
                    var deadLine = DateTime.Now;
                    var lastDayOfMonth = DateTime.DaysInMonth(deadLine.Year, deadLine.Month);
                    if (deadLine.Day + 15 > lastDayOfMonth)
                    {
                        deadLine = new DateTime(deadLine.Year, deadLine.Month + 1, 15 - (lastDayOfMonth - deadLine.Day));
                    }
                    else
                    {
                        deadLine = new DateTime(deadLine.Year, deadLine.Month, deadLine.Day + 15);
                    }
                        Guid codeBook = new Guid();
                        foreach (DataGridViewRow item in dataGridStorageOfBooks.SelectedRows)
                        {
                            Selected = item.Cells[6].Value.ToString();
                        }
                        codeBook = Guid.Parse(Selected);
                        Books book = booksRepo.FindBookByCode(codeBook);

                        if (book.BookState == 2 && member != null && book.BookCondition == 0)
                        {
                            borrowed = new Borrowed()
                            {
                                BookCode = codeBook,
                                MemberId = member.MemberId,
                                TimeOfBorrow = DateTime.Now,
                                DeadLineForBorrow = deadLine
                            };
                            borrowedRepo.AddToBorrowed(borrowed);
                            booksRepo.ChangeBookState(codeBook, 0);
                            MessageBox.Show("کتاب با موفقیت ثبت شد", "Success");
                        }
                        else if (book.BookState == 0)
                        {
                            MessageBox.Show("این کتاب در امانت شخص دیگری می باشد");
                        }
                        else if (book.BookCondition != 0)
                        {
                            MessageBox.Show("این کتاب قابل امانت نمی باشد");
                        }
                        else if (book.BookState == 1)
                        {
                            bool check = reservationRepo.CheckIfBookIsReservedByUser(member.NationalCode, codeBook);
                            if (check)
                            {
                                borrowed = new Borrowed()
                                {
                                    BookCode = codeBook,
                                    MemberId = member.MemberId,
                                    TimeOfBorrow = DateTime.Now,
                                    DeadLineForBorrow = deadLine
                                };
                                borrowedRepo.AddToBorrowed(borrowed);
                                booksRepo.ChangeBookState(codeBook, 0);
                                MessageBox.Show("کتاب با موفقیت ثبت شد", "Success");
                            }
                        
                        else
                        {
                            MessageBox.Show("این کتاب قبلا توسط شخص دیگری رزرو شده است");
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void BorrowedBooks_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateGrid();
                var foundBorroweds = borrowedRepo.GetAllBorroweds();
                List<Guid> codeBooks = new List<Guid>();
                List<Books> foundBooks = new List<Books>();
                foreach (var item in foundBorroweds)
                {
                    codeBooks.Add(item.BookCode);
                }
                codeBooks = codeBooks.Distinct().ToList();
                foreach (var item in codeBooks)
                {
                    foundBooks.Add(booksRepo.FindBookByCode(item));
                }
                var results = (from a in foundBooks where a.BookState==0
                               select new
                               {
                                   نام = a.AuthorName + "  " + a.AuthorFName,
                                   موضوع = a.Subject,
                                   سال = a.PublishYear,
                                   عنوان = a.Title,
                                   قیمت = a.Price,
                                   خریدکتاب = a.PurchasedTime,
                                   کدکتاب = a.Code
                               }).ToList();
                dataGridStorageOfBooks.DataSource = results;
            }
            catch (Exception)
            {
                UpdateGrid();
            }
        }

        private void btnSubmitBookCondition_Click(object sender, EventArgs e)
        {
           // UpdateGrid();
            if (txtExplanation.Text=="")
            {
                lblExplanations.Visible = true;
            }
            if (dataGridStorageOfBooks==null || dataGridStorageOfBooks.SelectedRows.Count!=1)
            {
                MessageBox.Show("لطفا خط رکورد مربوط به کتاب مورد نظر را انتخاب کنید", "خطا");
            }
            else if (rdBtnGoodBooks.Checked && txtExplanation.Text!="")
            {
                string Selected = "";
                Guid codeBook = new Guid();
                foreach (DataGridViewRow item in dataGridStorageOfBooks.SelectedRows)
                {
                    Selected = item.Cells[6].Value.ToString();
                }
                codeBook = Guid.Parse(Selected);
                booksRepo.ChangeBookCondition(codeBook, 0, txtExplanation.Text);
                MessageBox.Show("وضعیت کتاب با موفقیت ثبت شد", "Success");
            }
            else if (rdBtnMissedBooks.Checked && txtExplanation.Text != "")
            {
                string Selected = "";
                Guid codeBook = new Guid();
                foreach (DataGridViewRow item in dataGridStorageOfBooks.SelectedRows)
                {
                    Selected = item.Cells[6].Value.ToString();
                }
                codeBook = Guid.Parse(Selected);
                booksRepo.ChangeBookCondition(codeBook, 1, txtExplanation.Text);
                MessageBox.Show("وضعیت کتاب با موفقیت ثبت شد", "Success");
            }
            else if (rdBtnTornBooks.Checked && txtExplanation.Text != "")
            {
                string Selected = "";
                Guid codeBook = new Guid();
                foreach (DataGridViewRow item in dataGridStorageOfBooks.SelectedRows)
                {
                    Selected = item.Cells[6].Value.ToString();
                }
                codeBook = Guid.Parse(Selected);
                booksRepo.ChangeBookCondition(codeBook, 2, txtExplanation.Text);
                MessageBox.Show("وضعیت کتاب با موفقیت ثبت شد", "Success");
            }
            else if (rdBtnOldBooks.Checked && txtExplanation.Text != "")
            {
                string Selected = "";
                Guid codeBook = new Guid();
                foreach (DataGridViewRow item in dataGridStorageOfBooks.SelectedRows)
                {
                    Selected = item.Cells[6].Value.ToString();
                }
                codeBook = Guid.Parse(Selected);
                booksRepo.ChangeBookCondition(codeBook, 3, txtExplanation.Text);
                MessageBox.Show("وضعیت کتاب با موفقیت ثبت شد", "Success");
            }
        }

        private void ReservedBooks_Click(object sender, EventArgs e)
        {
            //Showing up the reseved cases in which the reserved time is the earliest
            try
            {
               // UpdateGrid();
                var foundReserveds = reservationRepo.GetAllReservations();
                List<Reservations> founds = new List<Reservations>();

                founds.Add(foundReserveds.OrderBy(a => a.ReservedTime).First());
                
                List<Guid> codeBooks = new List<Guid>();
                List<Books> foundBooks = new List<Books>();
                List<Guid> memberIds = new List<Guid>();
                List<Members> members = new List<Members>();
                foreach (var item in founds)
                {
                    codeBooks.Add(item.BookCode);
                }
                foreach (var item in codeBooks)
                {
                    foundBooks.Add(booksRepo.FindBookByCode(item));
                }
                foreach (var item in foundBooks)
                {
                    if (item.BookState!=1)
                    {
                        foundBooks.Remove(item);
                    }
                }
                var results = (from found in founds
                               join book in foundBooks on found.BookCode equals book.Code
                               select new
                               {
                                   کدملی = found.nationalCode,
                                   کتاب = book.Title
                               }).ToList();
                dataGridStorageOfBooks.DataSource = results;
            }
            catch (Exception)
            {
                UpdateGrid();
            }
        }

        private void btnDeliverToLib_Click(object sender, EventArgs e)
        {
            //There is no need to check who has borrowed the book earlier
            //and it's just enough to change state of the book and
            //make it available for borrow or reserve in library
            try
            {
                string Selected = "";
                foreach (DataGridViewRow item in dataGridStorageOfBooks.SelectedRows)
                {
                    Selected = item.Cells[6].Value.ToString();
                }
                Guid codeBook = Guid.Parse(Selected);
                Books book = booksRepo.FindBookByCode(codeBook);
                if (book.BookState == 0)
                {
                    booksRepo.ChangeBookState(codeBook, 2);
                    borrowedRepo.DeliverBookToLib(codeBook, DateTime.Now);
                    MessageBox.Show("کتاب با موفقیت ثبت شد", "Success");
                }
                else
                {
                    MessageBox.Show("کتاب قبلا تحویل داده شده است", "هشدار");
                }
            }
            catch (Exception)
            {
            }
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
                //context.SaveChangesForBorroweds(borroweds);
                List<Members> members = membersRepo.GetAllMembers();
                var results = (from book in borroweds
                               join member in members on book.MemberId equals member.MemberId where book.fines>0
                               select new
                               {
                                   کدملی = member.NationalCode,
                                   جریمه = book.fines
                               }).ToList();
                dataGridStorageOfBooks.DataSource = results;
                
            }
            catch (Exception)
            {
                
            }
        }

        private void btnEditbook_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridStorageOfBooks.RowCount > 1 && dataGridStorageOfBooks.SelectedRows.Count != 1)
                {
                    MessageBox.Show("لطفا کتاب مورد نظر را انتخاب کنید", "خطا");
                }
                else if (dataGridStorageOfBooks.RowCount == 1)
                {
                    string code = dataGridStorageOfBooks[6, 0].Value.ToString();
                    var th = new Thread(() => Application.Run(new EditBooks(code)));
                    th.Start();
                }
                else if (dataGridStorageOfBooks.SelectedRows.Count == 1)
                {
                    string code = "";
                    foreach (DataGridViewRow item in dataGridStorageOfBooks.SelectedRows)
                    {
                        code = item.Cells[6].Value.ToString();
                    }
                    var th = new Thread(() => Application.Run(new EditBooks(code)));
                    th.Start();
                }
                else
                {
                    MessageBox.Show("لطفا کتاب انتخاب کنید", "خطا");
                }
            }
            catch (Exception)
            {
               
            }
            
        }
    }
}