using BookStore.DAL.Configuration;
using BookStore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Database
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions option) : base(option)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrower> Borrower { get; set; }
        public DbSet<BorrowerBook> BorrowerBook { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new BooksEntityTypeConfiguration().Configure(modelBuilder.Entity<Book>());
            new BorrowerEntityTypeConfiguration().Configure(modelBuilder.Entity<Borrower>());
            new BorrowBookEntityTypeConfiguration().Configure(modelBuilder.Entity<BorrowerBook>());

        }
    }
}
