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
    public partial class SaveNewBooks : Form
    {
        Books books;
        BooksRepository booksRepository;
        public SaveNewBooks()
        {
            InitializeComponent();
            books = new Books();
            booksRepository = new BooksRepository();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text=="")
            {
                lblBook.Visible = true;
            }
            else if (txtBookName.Text != "")
            {
                lblBook.Visible = false;
            }
            if (txtAuthorName.Text == "")
            {
                lblAuthorName.Visible = true;
            }
            else if (txtAuthorName.Text != "")
            {
                lblAuthorName.Visible = false;
            }
            if (txtAuthorFname.Text == "")
            {
                lblAuthorFname.Visible = true;
            }
            else if (txtAuthorFname.Text != "")
            {
                lblAuthorFname.Visible = false;
            }
            if (lblBook.Visible==false && lblAuthorName.Visible==false && lblAuthorFname.Visible==false)
            {
                DateTime date = DateTime.Now;

                books = new Books()
                {
                    BookCondition = 0,
                    BookState = 2,
                    AuthorName = txtAuthorName.Text,
                    AuthorFName = txtAuthorFname.Text,
                    Title = txtBookName.Text,
                    Subject = txtSubject.Text,
                    PublishYear = cmbBoxPublishYear.SelectedItem.ToString(),
                    PurchasedTime = date,
                    Price = txtPrice.Text
                };
                booksRepository.AddNewBook(books);
            }
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookName.Text = "";
            txtAuthorName.Text = "";
            txtAuthorFname.Text = "";
            txtSubject.Text = "";
            txtPrice.Text = "";
            cmbBoxPublishYear.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var books = booksRepository.SearchBooksByTitle(txtBookName.Text);
                if (books.Count>1)
                {
                    List<Books> foundBooks = new List<Books>();
                    foreach (var item in books)
                    {
                        if (txtAuthorName.Text==item.AuthorName && txtAuthorFname.Text==item.AuthorFName && txtSubject.Text==item.Price && cmbBoxPublishYear.SelectedItem.ToString()==item.PublishYear)
                        {
                            booksRepository.DeleteBook(item.Code);
                        }
                    }
                    
                }
                else if (books.Count==1)
                {
                    booksRepository.DeleteBook(books[0].Code);
                }
                else if (books.Count==0)
                {
                    MessageBox.Show("کتابی با این عنوان یافت نشد", "خطا");
                }
                
            }
            catch (Exception)
            {

                
            }
        }
    }
}
