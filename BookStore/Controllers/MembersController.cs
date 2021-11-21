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
    public class MembersController : Controller
    {
        private readonly IBorrowerRepository _memberRepository;
        private readonly IMapper _mapper;
        private readonly IBorrowerBookRepository borrowerBookRepository;

        public MembersController(IBorrowerRepository memberRepository, IMapper mapper , IBorrowerBookRepository borrowerBookRepository)
        {
            this._memberRepository = memberRepository;
            this._mapper = mapper;
            this.borrowerBookRepository = borrowerBookRepository;
        }

        public IActionResult Index()
        {
            var model = _memberRepository.Get();
            var data = _mapper.Map<IEnumerable<CreateBorrowerVM>>(model);
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateBorrowerVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = _mapper.Map<Borrower>(model);
                    _memberRepository.Create(data);
                    return RedirectToAction("Index", "Members");
                }
                return View();

            }
            catch (Exception ex)
            {

                return View(ex.Message);
            }

        }

        public IActionResult Edit(int id)
        {
            var model = _memberRepository.GetById(id);
            if (model == null)
            {
                return RedirectToAction("NotFound", "Books");
            }
            var data = _mapper.Map<UpdateBorrowerVM>(model);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(UpdateBorrowerVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _memberRepository.Update(model);
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
            var model = _memberRepository.GetById(id);
            if (model == null)
            {
                return RedirectToAction("NotFound", "Books");
            }
            var data = _mapper.Map<CreateBorrowerVM>(model);
            return View(data);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            try
            {
                var model = _memberRepository.GetById(id);


                _memberRepository.Delete(model);
                return RedirectToAction("Index", "Books");
            }
            catch
            {
                return View();
            }
        }

        public IActionResult BorrowedBooks(int id)
        {
            var model = borrowerBookRepository.GetBorrowedBooks(id);
            
            return View(model);

        }

        [HttpPost]
        public IActionResult BorrowedBooks(ReturnBookVM returnBook)
        {
            borrowerBookRepository.ReturnBook(returnBook);
            return RedirectToAction("Index","BorrowedBooks") ;
        }




    }
}
