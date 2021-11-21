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
    public class BorrowerRepository : IBorrowerRepository
    {
        private readonly BookStoreDbContext db;

        public BorrowerRepository(BookStoreDbContext db)
        {
            this.db = db;
        }

        public void Create(Borrower obj)
        {
            db.Borrower.Add(obj);
            db.SaveChanges();
        }

        public void Delete(Borrower obj)
        {

            db.Borrower.Remove(obj);
            db.SaveChanges();
        }

        public IEnumerable<Borrower> Get()
        {
            var data = db.Borrower
                .Include(e => e.BorrowerBook).ThenInclude(e => e.Borrower).Select(e => e);
            return data;
        }

        public IEnumerable<Borrower> GetBorrowedBooks(int borrowerid)
        {
            var data = db.Borrower
                .Include(e => e.BorrowerBook).ThenInclude(e => e.Borrower).Where(e => e.Id == borrowerid).Select(e=>e);

            return data;
        }

        public Borrower GetById(int id)
        {
            var data = db.Borrower
                                .AsNoTracking()

                .Where(emp => emp.Id == id).AsNoTracking().FirstOrDefault();

            return data;
        }

        public void Update(UpdateBorrowerVM obj)
        {

            var entity = this.db.Borrower.Where(x => x.Id == obj.Id).FirstOrDefault();

            entity.Name = obj.Name;
            db.Borrower.Update(entity);
            db.SaveChanges();
        }

        public bool CheckExistByCode(string code)
        {

            var data = db.Borrower.Where(x => x.Code == code).FirstOrDefault();
            if (data == null)
                return false;
            else
                return true;

        }
    }
}
