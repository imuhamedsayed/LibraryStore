using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Models
{
   public class CreateBookVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "The Stock field is required.")]
        public int Stock { get; set; }

        public int ActiveReserved
        {
            get;set;
        }

        public int TotalReservations { get; set; }


        public bool IsReservable { get; set; }

    }


    public class UpdateBookVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "The Stock field is required.")]
        public int Stock { get; set; }

        public int ActiveReserved
        {
            get; set;
        }

        public int TotalReservations { get; set; }


        public bool IsReservable { get; set; }

    }

}
