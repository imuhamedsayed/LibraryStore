﻿// <auto-generated />
using System;
using BookStore.DAL.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStore.DAL.Migrations
{
    [DbContext(typeof(BookStoreDbContext))]
    [Migration("20211121075239_AddConstraint4")]
    partial class AddConstraint4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStore.DAL.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActiveReserved")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique()
                        .HasFilter("[Code] IS NOT NULL");

                    b.ToTable("Books");

                    b.HasCheckConstraint("CK_Books_ActiveReserved", "[ActiveReserved] <= [Stock]");
                });

            modelBuilder.Entity("BookStore.DAL.Entities.Borrower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique()
                        .HasFilter("[Code] IS NOT NULL");

                    b.ToTable("Borrower");
                });

            modelBuilder.Entity("BookStore.DAL.Entities.BorrowerBook", b =>
                {
                    b.Property<int>("BorrowerId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BorrowAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Returned")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ReturnedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("BorrowerId", "BookId", "BorrowAt");

                    b.HasIndex("BookId");

                    b.ToTable("BorrowerBook");
                });

            modelBuilder.Entity("BookStore.DAL.Entities.BorrowerBook", b =>
                {
                    b.HasOne("BookStore.DAL.Entities.Book", "Book")
                        .WithMany("BorrowerBook")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.DAL.Entities.Borrower", "Borrower")
                        .WithMany("BorrowerBook")
                        .HasForeignKey("BorrowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Borrower");
                });

            modelBuilder.Entity("BookStore.DAL.Entities.Book", b =>
                {
                    b.Navigation("BorrowerBook");
                });

            modelBuilder.Entity("BookStore.DAL.Entities.Borrower", b =>
                {
                    b.Navigation("BorrowerBook");
                });
#pragma warning restore 612, 618
        }
    }
}
