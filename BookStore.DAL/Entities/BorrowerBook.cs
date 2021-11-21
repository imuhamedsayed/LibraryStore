using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Entities
{

    
  public class BorrowerBook
    {
       
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int BorrowerId { get; set; }
        public Borrower Borrower { get; set; }
        public DateTime BorrowAt { get; set; }
        public DateTime ReturnedAt { get; set; }
        public bool Returned { get; set; }
        

        public BorrowerBook(int bookId,  int borrowerId)
        {
            BookId = bookId;
            BorrowerId = borrowerId; 
            Returned = false;
            BorrowAt = DateTime.Now;
        }


        public void Return()
        {
            ReturnedAt = DateTime.Now;
            Returned = true;
            this.Book.ActiveReserved = this.Book.ActiveReserved - 1;
        }
    }
}
