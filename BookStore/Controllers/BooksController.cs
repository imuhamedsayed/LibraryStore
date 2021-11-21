using AutoMapper;
using BookStore.BL.Interface;
using BookStore.BL.Models;
using BookStore.BL.Repository;
using BookStore.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksRepository _booksRepository;
        private readonly IBorrowerBookRepository borrowerBookRepository;
        private readonly IMapper mapper;

        public BooksController(IBooksRepository booksRepository,IBorrowerBookRepository borrowerBookRepository ,IMapper mapper)
        {
            this._booksRepository = booksRepository;
            this.borrowerBookRepository = borrowerBookRepository;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _booksRepository.Get();
            var data = mapper.Map<IEnumerable<CreateBookVm>>(model);
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateBookVm model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Book>(model);
                    _booksRepository.Create(data);
                    return RedirectToAction("Index", "Books");
                }
                else
                return View();

            }
            catch (Exception ex)
            {

                return View(ex.Message);
            }

        }

        public IActionResult Edit(int id)
        {
            var model = _booksRepository.GetById(id);
            var data = mapper.Map<UpdateBookVm>(model);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(UpdateBookVm model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _booksRepository.Update(model);
                    return RedirectToAction("Index", "Books");
                }
                return View();

            }   
            catch (Exception ex)
            {

                return View(ex.Message);
            }

        }

        public IActionResult Delete(int id)
        {
            var model = _booksRepository.GetById(id);
            var data = mapper.Map<CreateBookVm>(model);
            return View(data);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            try
            {
                var model = _booksRepository.GetById(id);
              
                _booksRepository.Delete(model);
                return RedirectToAction("Index", "Books");
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Borrow(int id)
        {
            var model = _booksRepository.GetById(id);
            if(model == null)
            {
                return RedirectToAction("NotFound", "Books");
            }
            
            var data = mapper.Map<CreateBookVm>(model);

            ViewBag.Book = new BorrowBookVM
            {
                BookCode = data.Code,
                BookName = data.Name,
                BorrowerCode = "",
                MemberName = ""
            };


            return View();
            
        }
        [HttpPost]
        public IActionResult Borrow(BorrowBookVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    borrowerBookRepository.BorrowBook(model);

                    return RedirectToAction("Index", "Members");
                }
                else
                {

                    ViewBag.Book = model;

                    return View();

                }


            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
                
        }

        public IActionResult NotFound(int id)
        {
            TempData["notfound"] = "Resource Not Found";
            return View();
        }


    

    }
}
