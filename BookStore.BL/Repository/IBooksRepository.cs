using BookStore.BL.Models;
using BookStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Interface
{
   public interface IBooksRepository
    {
        IEnumerable<Book> Get();
       
        void Create(Book obj);
        void Update(UpdateBookVm obj);
        void Delete(Book obj);
        Book GetById(int id);
        Book GetByCode(string code);
        bool CheckExistByCode(string code);
    }
}
