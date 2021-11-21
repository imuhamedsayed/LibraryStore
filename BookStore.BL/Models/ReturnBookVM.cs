using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Models
{
   public class ReturnBookVM
    {
        public int BookId { get; set; }
        public int BorrowerId { get; set; }

    }
}
