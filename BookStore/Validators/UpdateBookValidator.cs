using BookStore.BL.Interface;
using BookStore.BL.Models;
using BookStore.BL.Repository;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Presentation.Validators
{
    public class UpdateBookValidator : AbstractValidator<UpdateBookVm>
    {
        private readonly IBooksRepository bookRepository;

        public UpdateBookValidator(IBooksRepository bookRepository)
        {
            this.bookRepository = bookRepository;

            RuleFor(t => t.Code).NotEmpty()
            .WithMessage("Code is Required")
            .Must(IsExist).WithMessage("Code Must Be Unique");


            RuleFor(t => t.Name).NotEmpty()
            .WithMessage("Name is Required");

            RuleFor(t => t.Stock).NotEmpty()
            .WithMessage("Stock is Required")
           .GreaterThan(-1)
           .WithMessage("Stock must be greater than or equal to 0");
        }

        private bool IsExist(string bookCode)
        {
            var checkExistResult = bookRepository.CheckExistByCode(bookCode);


            return checkExistResult;
        }


    }
}
