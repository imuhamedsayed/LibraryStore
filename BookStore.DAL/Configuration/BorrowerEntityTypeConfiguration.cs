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
   public class BorrowerEntityTypeConfiguration : IEntityTypeConfiguration<Borrower>
    {
        public void Configure(EntityTypeBuilder<Borrower> builder)
        {
            builder.Property(n => n.Name).HasMaxLength(50);
            builder.Property(n => n.Code).HasMaxLength(50);
            builder.HasIndex(c => c.Code).IsUnique();
        }
    }
}
