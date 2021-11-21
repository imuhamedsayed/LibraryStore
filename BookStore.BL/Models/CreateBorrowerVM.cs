using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Models
{
   public class CreateBorrowerVM
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class UpdateBorrowerVM
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

}
