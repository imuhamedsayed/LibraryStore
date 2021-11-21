using BookStore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Configuration
{
    public class BorrowBookEntityTypeConfiguration : IEntityTypeConfiguration<BorrowerBook>
    {
        public void Configure(EntityTypeBuilder<BorrowerBook> builder)
        {
            builder.HasKey(sc => new { sc.BorrowerId, sc.BookId, sc.BorrowAt });
        }
    }
}
