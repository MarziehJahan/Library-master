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
    public partial class EditBooks : Form
    {
        Books books;
        BooksRepository booksRepository;
        public EditBooks(string codebook)
        {
            InitializeComponent();
            lblCodeBook.Text = codebook;
            books = new Books();
            booksRepository = new BooksRepository();
            InitializeEdit();
        }
        public void InitializeEdit()
        {
            try
            {
                Guid code = Guid.Parse(lblCodeBook.Text);
                var book = booksRepository.FindBookByCode(code);
                txtAuthorName.Text = book.AuthorName;
                txtAuthorFname.Text = book.AuthorFName;
                txtBookName.Text = book.Title;
                txtSubject.Text = book.Subject;
                txtPrice.Text = book.Price;
            }
            catch (Exception)
            {

            }
            
        }
        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var book = booksRepository.SearchBooksByTitle(txtSubject.Text);
                txtAuthorName.Text = book[0].AuthorName;
                txtAuthorFname.Text = book[0].AuthorFName;
                txtSubject.Text = book[0].Subject;
                txtPrice.Text = book[0].Price;
                cmbBoxPublishYear.Text = book[0].PublishYear;
            }
            catch (Exception)
            {
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text == "")
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
            if (lblBook.Visible == false && lblAuthorName.Visible == false && lblAuthorFname.Visible == false)
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
                Guid Codebook = Guid.Parse(lblCodeBook.Text);
                booksRepository.EditBook(Codebook, books);
                MessageBox.Show("تغییرات با موفقیت انجام شد", "Success");
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Guid bookcode = Guid.Parse(lblCodeBook.Text);
                booksRepository.DeleteBook(bookcode);
                MessageBox.Show("کتاب حذف گردید", "Success");

            }
            catch (Exception)
            {


            }
        }
    }
}
