using Library.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MainPage : Form
    {
        Timer timer;
        PersianCalendar pc = new PersianCalendar();
        BooksRepository booksRepo;
        public MainPage()
        {
            InitializeComponent();
            booksRepo = new BooksRepository();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(MainPage_Load);
            timer.Enabled = true;
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            lblNumOfAllBooks.Text = booksRepo.NumOfAllBooks().ToString();
            try
            {
                var foundBooks = booksRepo.GetAllBooks();
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
                dataGridSearchBooks.DataSource = results;
            }
            catch (Exception)
            {

            }
            DateTime timer = DateTime.Now;
            lblTimer.Text = timer.Hour + " : " + timer.Minute + " : " + timer.Second;
            lblDate.Text = pc.GetYear(timer) + "/" + pc.GetMonth(timer) + "/" + pc.GetDayOfMonth(timer);
        }
        private void menuLogin_Click(object sender, EventArgs e)
        {
            var loginThread = new System.Threading.Thread(() => Application.Run(new Login()));
            loginThread.Start();
        }

        private void menuRegister_Click(object sender, EventArgs e)
        {
            var RegisterationThread = new System.Threading.Thread(() => Application.Run(new RegisterMember()));
            RegisterationThread.Start();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void SearchStorageByAuthor_Click(object sender, EventArgs e)
        {

        }

        private void SearchStorageBySubject_Click(object sender, EventArgs e)
        {

        }

        private void SearchStorageByPublishYear_Click(object sender, EventArgs e)
        {

        }

        private void SearchStorageByTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
