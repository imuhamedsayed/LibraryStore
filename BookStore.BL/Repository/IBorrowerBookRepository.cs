using BookStore.BL.Models;
using BookStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Repository
{
    public interface IBorrowerBookRepository
    {
        public void BorrowBook(BorrowBookVM borrowBook);

        public void ReturnBook(ReturnBookVM returnBook);
        IEnumerable<BorrowerBook> GetBorrowedBooks(int borrowerid);
        IEnumerable<BorrowerBook> GetAllBorrowedBooks();
    }
}
