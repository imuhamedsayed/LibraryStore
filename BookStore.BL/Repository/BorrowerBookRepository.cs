using BookStore.BL.Models;
using BookStore.DAL.Database;
using BookStore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Repository
{
    public class BorrowerBookRepository : IBorrowerBookRepository
    {
        private readonly BookStoreDbContext db;

        public BorrowerBookRepository(BookStoreDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<BorrowerBook> GetBorrowedBooks(int borrowerid)
        {
            var data = db.BorrowerBook.Include(e => e.Book).Include(e => e.Borrower).Where(e => e.Borrower.Id == borrowerid).Select(e => e);
            return data;
        }

        public IEnumerable<BorrowerBook> GetAllBorrowedBooks()
        {
            var data = db.BorrowerBook.Include(e => e.Book).Include(e => e.Borrower).Select(e => e);
            return data;
        }
        public void BorrowBook(BorrowBookVM borrowBook)
        {

            var borrower = db.Borrower.Where(e => e.Code == borrowBook.BorrowerCode).FirstOrDefault();
            var book = db.Books.Where(e => e.Code == borrowBook.BookCode).FirstOrDefault();

            if (borrower == null || book == null)
                throw new Exception("Resouces Not Found");

            try
            {
                book.Reserve();
                db.Update(book);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex; 
            }


            var model = new BorrowerBook(book.Id, borrower.Id);
            db.BorrowerBook.Add(model);
            db.SaveChanges();

            return;

        }

        public void ReturnBook(ReturnBookVM returnBook)
        {
            var book = db.BorrowerBook
                .Include(x => x.Book)
                .Where(e => e.BookId == returnBook.BookId && e.BorrowerId == returnBook.BorrowerId && e.Returned == false).FirstOrDefault();

            book.Return();
            db.Update(book);
            db.SaveChanges();
        }
    }
}
