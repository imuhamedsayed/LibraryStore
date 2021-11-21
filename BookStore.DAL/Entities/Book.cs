using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Entities
{
  public class Book
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Stock { get; set; }

        private int _activeReservations;

        public int ActiveReserved { get { return _activeReservations; } set {

                if (Stock == 0)
                    this._activeReservations = value;

                else if (value <= Stock)
                {
                    this._activeReservations = value;

                }
                else
                {
                    throw new InvalidOperationException("Book is out of stock");

                }
            }
        }

        public int TotalReservations { get { return BorrowerBook.Count(); } }

        public bool IsReservable { get { return CanReserve(); } }
        public ICollection<BorrowerBook> BorrowerBook { get; set; }

        public Book()
        {
            BorrowerBook = new Collection<BorrowerBook>();
            _activeReservations = 0;
        }

        public bool CanReserve()
        {
            if (_activeReservations + 1 > Stock)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        public void Reserve()
        {
                this.ActiveReserved = _activeReservations+1;
        }

    }
}
