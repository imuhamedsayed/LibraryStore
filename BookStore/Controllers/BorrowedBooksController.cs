using AutoMapper;
using BookStore.BL.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Presentation.Controllers
{
    public class BorrowedBooksController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBorrowerBookRepository borrowerBookRepository;

        public BorrowedBooksController( IMapper mapper, IBorrowerBookRepository borrowerBookRepository)
        {
            
            this._mapper = mapper;
            this.borrowerBookRepository = borrowerBookRepository;
        }
        public IActionResult Index()
        {
            var data = borrowerBookRepository.GetAllBorrowedBooks();
            return View(data);
        }
    }
}
