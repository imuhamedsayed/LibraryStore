using BookStore.BL.Interface;
using BookStore.BL.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Presentation.Validators
{
    public class UpdateBorrowerValidator : AbstractValidator<UpdateBorrowerVM>
    {
        private readonly IBorrowerRepository borrowerRepository;

        public UpdateBorrowerValidator(IBorrowerRepository borrowerRepository)
        {
            this.borrowerRepository = borrowerRepository;


            RuleFor(t => t.Code).NotEmpty()
            .WithMessage("Code is Required")
            .Must(MemberExist).WithMessage("Code Must Be Unique");


            RuleFor(t => t.Name).NotEmpty()
            .WithMessage("Name is Required");


        }

        private bool IsUnique(string borrowerCode)
        {
            var checkExistResult = borrowerRepository.CheckExistByCode(borrowerCode);


            return !checkExistResult;
        }


        private bool MemberExist(string arg)
        {
            var exist = this.borrowerRepository.CheckExistByCode(arg);

            return exist;
        }

    }
}
