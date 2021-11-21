using BookStore.BL.Models;
using BookStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Interface
{
   public interface IBorrowerRepository
    {
        IEnumerable<Borrower> Get();

        void Create(Borrower obj);
        void Update(UpdateBorrowerVM obj);
        void Delete(Borrower obj);
        Borrower GetById(int id);
        IEnumerable<Borrower> GetBorrowedBooks(int borrowerid);
        bool CheckExistByCode(string code);
    }
}
