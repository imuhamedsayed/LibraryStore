using AutoMapper;
using BookStore.BL.Models;
using BookStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Book, CreateBookVm>();
            CreateMap<CreateBookVm, Book>().ForMember(x => x.BorrowerBook, opt => opt.Ignore());
            CreateMap<Book, UpdateBookVm>();
            CreateMap<UpdateBookVm, Book>().ForMember(x => x.BorrowerBook, opt => opt.Ignore());

            CreateMap<Borrower, CreateBorrowerVM>();
            CreateMap<Borrower, UpdateBorrowerVM>();
            CreateMap<CreateBorrowerVM, Borrower>().ForMember(x => x.BorrowerBook, opt => opt.Ignore());


            CreateMap<UpdateBorrowerVM, Borrower>().ForMember(x => x.BorrowerBook, opt => opt.Ignore());
            

        }
    }
}
