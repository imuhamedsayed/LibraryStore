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
    public class BooksEntityTypeConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(n => n.Name).HasMaxLength(50);
            builder.Property(n => n.Code).HasMaxLength(50);
            builder.HasIndex(c => c.Code).IsUnique();
            builder.Property(c => c.ActiveReserved);
            builder.HasCheckConstraint("CK_Books_ActiveReserved", "[ActiveReserved] <= [Stock]");
            builder.HasCheckConstraint("CK_Books_ActiveReserved_GreatherThanZero", "[ActiveReserved] >= 0");
            builder.HasCheckConstraint("CK_Books_Stock_GreaterThanZero", "[Stock] > 0");

        }
    }
}
