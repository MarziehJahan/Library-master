using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    class BooksRepository
    {
        Context context;
        public BooksRepository()
        {
            context = new Context();
        }
        public void AddNewBook(Books book)
        {
            var data = context.books();
            if (data==null)
            {
                data = new List<Books>();
            }
            data.Add(book);
            context.SaveChangesForBooks(data);
        }
        public List<Books> GetAllBooks()
        {
            return context.books();
        }
        public Books FindBookByCode(Guid code)
        {
            return GetAllBooks().Single(a => a.Code == code);
        }
        public List<Books> SearchBooksByAuthorName(string authorName)
        {
            try
            {
                List<Books> books = GetAllBooks().FindAll(a => a.AuthorName.Contains(authorName) && a.BookCondition == 0);
                return books;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<Books> SearchBooksByAuthorFname(string authorFname)
        {
            try
            {
                List<Books> books = GetAllBooks().FindAll(a => a.AuthorFName.Contains(authorFname) && a.BookCondition == 0);
                return books;
            }
            catch (Exception)
            {

                return null;
            }
            
        }
        public List<Books> SearchBooksBySubject(string subject)
        {
            try
            {
                List<Books> books = GetAllBooks().FindAll(a => a.Subject.Contains(subject) && a.BookCondition==0);
                return books;
            }
            catch (Exception)
            {

                return null;
            }
           
        }
        public List<Books> SearchBooksByPublishedYear(string year)
        {
            try
            {
                List<Books> books = GetAllBooks().FindAll(a => a.PublishYear.Contains(year) && a.BookCondition == 0);
                return books;
            }
            catch (Exception)
            {

                return null;
            }
            
        }
        public List<Books> SearchBooksByTitle(string title)
        {
            try
            {
                List<Books> books = GetAllBooks().FindAll(a => a.Title.Contains(title) && a.BookCondition == 0);
                return books;
            }
            catch (Exception)
            {

                return null;
            }
            
        }
        public List<Books> MissedBooks()
        {
            try
            {
                List<Books> books = GetAllBooks().FindAll(a => a.BookCondition == 1);
                return books;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<Books> MatteredBooks()
        {
            try
            {
                List<Books> books = GetAllBooks().FindAll(a => a.BookCondition == 2 || a.BookCondition == 3);
                return books;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public void ChangeBookCondition(Guid codeBook,int condition,string exp)
        {
            var data = context.books();
            Books book = FindBookByCode(codeBook);
            int tmp = data.FindIndex(a => a.Code == codeBook);
            book.BookCondition = condition;
            book.Explanation = exp;
            data[tmp] = book;
            context.SaveChangesForBooks(data);
        }
        public void ChangeBookState(Guid codeBook,int state)
        {
            var data = context.books();
            Books book = FindBookByCode(codeBook);
            int tmp = data.FindIndex(a => a.Code == codeBook);
            book.BookState = state;
            data[tmp] = book;
            context.SaveChangesForBooks(data);
        }
        public int NumOfAllBooks()
        {
            try
            {
                return GetAllBooks().Count;
            }
            catch (Exception)
            {
                return 0;
            }
            
        }
        public void DeleteBook(Guid code)
        {
            try
            {
                var data = context.books();
                int tmp = data.FindIndex(a => a.Code == code);
                data.RemoveAt(tmp);
                context.SaveChangesForBooks(data);
            }
            catch (Exception)
            {
                
            }
        }
        public void EditBook(Guid code,Books Book)
        {
            var book = FindBookByCode(code);
            var data = context.books();
            int tmp = data.FindIndex(a => a.Code == code);
            book.AuthorName = Book.AuthorName;
            book.AuthorFName = Book.AuthorFName;
            book.Title = Book.Title;
            book.Subject = Book.Subject;
            book.PublishYear = Book.PublishYear;
            book.Price = Book.Price;
            data[tmp] = book;
            context.SaveChangesForBooks(data);
        }
    }
}
