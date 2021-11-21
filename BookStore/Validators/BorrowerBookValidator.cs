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
    public class BorrowerBookValidator  : AbstractValidator<BorrowBookVM>
    {
        private readonly IBorrowerBookRepository borrowerBookRepository;
        private readonly IBooksRepository booksRepository;
        private readonly IBorrowerRepository borrwerRepository;

        public BorrowerBookValidator(IBorrowerBookRepository borrowerBookRepository,IBooksRepository booksRepository, IBorrowerRepository borrwerRepository)
        {
            this.borrowerBookRepository = borrowerBookRepository;
            this.booksRepository = booksRepository;
            this.borrwerRepository = borrwerRepository;


            RuleFor(x => x.BorrowerCode)
                .NotEmpty()
                .WithMessage("Borrower Code Required")
                .Must(MemberExist)
                .WithMessage("Member not exist");

            RuleFor(x => x.BookCode)
                .NotEmpty()
                .WithMessage("Book Code Required")
                .Must(BookExist)
                .WithMessage("Book not exist");

        }

/*        private bool HaveQuantity(string arg)
        {
            var book = this.booksRepository.
        }

        private bool AlreadyBorrowThisBook(string arg)
        {
            var borrowExist = this.borrowerBookRepository.
        }
*/
        private bool MemberExist(string arg)
        {
            var exist = this.borrwerRepository.CheckExistByCode(arg);

            return exist;
        }

        private bool BookExist(string arg)
        {
            var exist = this.booksRepository.CheckExistByCode(arg);

            return exist;
        }

    }
}
