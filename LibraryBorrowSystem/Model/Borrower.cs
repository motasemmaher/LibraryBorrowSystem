using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBorrowSystem.Model
{
    public abstract class Borrower
    {
        private List<int> borrowedItems; // item IDs
        private string email;
        private string name;
        private int id;
        private int maxAllowedItems;

        protected Borrower()
        {
            this.borrowedItems = new List<int>();
        }

        protected Borrower(string email, string name, int id, int maxAllowedItems)
        {
            this.borrowedItems = new List<int>();
            this.email = email;
            this.name = name;
            this.id = id;
            this.maxAllowedItems = maxAllowedItems;
        }

        public List<int> BorrowedItems { get => borrowedItems; set => borrowedItems = value; }
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int MaxAllowedItems { get => maxAllowedItems; set => maxAllowedItems = value; }
        public override bool Equals(object obj)
        {
            return obj is Borrower && this.id == (obj as Borrower).id;
        }
        public override string ToString()
        {
            string str = string.Format("{0},{1},{2},{3}", id, name, email, maxAllowedItems);
            for (int i = 0; i < borrowedItems.Count; ++i)
            {
                str += "," + borrowedItems[i];
            }
            return str;
        }
    }
}
