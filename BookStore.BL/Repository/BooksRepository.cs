using BookStore.BL.Interface;
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
    public class BooksRepository : IBooksRepository
    {
        private readonly BookStoreDbContext db;

        public BooksRepository(BookStoreDbContext db)
        {
            this.db = db;
        }

        public void Create(Book obj)
        {
            db.Books.Add(obj);
            db.SaveChanges();
        }

        public void Delete(Book obj)
        {

            db.Books.Remove(obj);
            db.SaveChanges();
        }

        public IEnumerable<Book> Get()
        {
            var data = db.Books
                                .Include(x => x.BorrowerBook)

                .Select(b => b).AsNoTracking();
            return data;
        }

        public Book  GetById(int id) 
        {
            var data = db.Books
                                                .AsNoTracking()

                .Include(x => x.BorrowerBook)
                .Where(e => e.Id == id).AsNoTracking()
                .FirstOrDefault();

            return data;
        }

        public void Update(UpdateBookVm obj)
        {
            var entity = db.Books.Where(x => x.Id == obj.Id).FirstOrDefault();
            entity.Name = obj.Name;
            db.Books.Update(entity);
            db.SaveChanges();

        }

        public bool CheckExistByCode(string code)
        {

            var data = db.Books.Where(x => x.Code == code).FirstOrDefault();
            if (data == null)
                return false;
            else
                return true;

        }

        public Book GetByCode(string code)
        {
            var data = db.Books.Where(book => book.Code == code).FirstOrDefault();

            return data;
        }
    }
}
