using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Models
{
    public class BorrowBookVM
    {
        public string BookName { get; set; }
        public string MemberName { get; set; }

        public string BookCode { get; set; }
        public  string BorrowerCode { get; set; }

    }


}
