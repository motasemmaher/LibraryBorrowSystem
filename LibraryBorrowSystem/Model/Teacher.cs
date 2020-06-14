using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBorrowSystem.Model
{
    public class Teacher : Borrower
    {
        public Teacher() : base()
        {

        }

        public Teacher(string phoneNumber, string name, int id, int maxAllowedItems) : base(phoneNumber, name, id, maxAllowedItems)
        {
            
        }
    }
}
