using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryBorrowSystem.Model;

namespace LibraryBorrowSystem.Controller
{
    public class DataRepository
    {

        private const string studentsFile = "./Data/Students.csv";
        private const string teachersFile = "./Data/Teachers.csv";
        private const string itemsFile = "./Data/Items.csv";
        private const string timeoutsFile = "./Data/Timeouts.csv";

        private List<Borrower> borrowers;
        private List<Item> items;

        public DataRepository()
        {
            borrowers = new List<Borrower>();
            items = new List<Item>();
            ReadData();
        }
        public bool AddBorrower(Model.Borrower borrower)
        {
            if (!borrowers.Contains(borrower))
            {
                borrowers.Add(borrower);
                WriteData();
                return true;
            }
            return false;
        }
        public bool RemoveBorrower(int borrowerId)
        {
            if (borrowers.Contains(new Student { Id = borrowerId }))
            {
                borrowers.Remove(GetBorrower(borrowerId));
                WriteData();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddItem(Item item)
        {
            if (!items.Contains(item))
            {
                items.Add(item);
                WriteData();
                return true;
            }
            return false;
        }

        public List<Borrower> GetAllBorrowers()
        {
            return borrowers;
        }

        public bool RemoveItem(int itemId)
        {
            if (items.Contains(new Item { ItemId = itemId }))
            {
                items.Remove(GetItem(itemId));
                WriteData();
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Item> GetAllItems()
        {
            return items;
        }
        public List<Item> GetLateItems()
        {
            var q = from Item i in items
                    where i.OverdueTimeout <= 0
                    select i;

            return q.ToList();
        }
        public List<Item> GetItems(int borrowerId)
        {
            List<int> borrowedItems = GetBorrower(borrowerId).BorrowedItems;
            var q = from Item i in items
                    where borrowedItems.Contains(i.ItemId)
                    select i;
            return q.ToList();
        }

        public Borrower GetBorrower(int borrowerId)
        {
            var q = from Borrower b in borrowers
                    where b.Id == borrowerId
                    select b;
            return q.Count() == 1 ? q.First() : null;
        }

        public Item GetItem(int itemId)
        {
            var q = from Item i in items
                    where i.ItemId == itemId
                    select i;
            return q.Count() == 1 ? q.First() : null;
        }

        public void SetItem(Item item)
        {
            items.Remove(item);
            items.Add(item);
            WriteData();
        }

        public void SetBorrower(Borrower borrower)
        {
            borrowers.Remove(borrower);
            borrowers.Add(borrower);
            WriteData();
        }

        public void ReadData()
        {
            borrowers.Clear();
            items.Clear();

            borrowers.AddRange(readStudents());
            borrowers.AddRange(readTeachers());
            items.AddRange(readItems());
        }
        public void WriteData()
        {
            writeStudents();
            writeTeachers();
            writeItems();
        }
        private List<Borrower> readStudents()
        {
            List<Borrower> studentsList = new List<Borrower>();
            string[] students = File.ReadAllLines(studentsFile);
            foreach (string line in students)
            {
                string[] data = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                Student stu = new Student();

                stu.Id = int.Parse(data[0]);
                stu.Name = data[1];
                stu.Email = data[2];
                stu.MaxAllowedItems = int.Parse(data[3]);

                for (int i = 4; i < data.Length; ++i)
                {
                    stu.BorrowedItems.Add(int.Parse(data[i]));
                }

                studentsList.Add(stu);
            }
            return studentsList;
        }
        private List<Borrower> readTeachers()
        {
            List<Borrower> teachersList = new List<Borrower>();
            string[] teachers = File.ReadAllLines(teachersFile);
            foreach (string line in teachers)
            {
                string[] data = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                Teacher tea = new Teacher();

                tea.Id = int.Parse(data[0]);
                tea.Name = data[1];
                tea.Email = data[2];
                tea.MaxAllowedItems = int.Parse(data[3]);

                for (int i = 4; i < data.Length; ++i)
                {
                    tea.BorrowedItems.Add(int.Parse(data[i]));
                }

                teachersList.Add(tea);
            }
            return teachersList;
        }
        private List<Item> readItems()
        {
            List<Item> itemsList = new List<Item>();
            string[] lines = File.ReadAllLines(itemsFile);
            foreach (string line in lines)
            {
                string[] data = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                Item it = new Item();

                it.ItemId = int.Parse(data[0]);
                it.Name = data[1];
                it.Category = data[2] == Category.Book.ToString() ? Category.Book : Category.CD;
                it.Price = double.Parse(data[3]);
                it.State = data[4] == State.Available.ToString() ? State.Available :
                    (data[4] == State.Unavailable.ToString() ? State.Unavailable : State.Reserved);
                it.BorrowerId = int.Parse(data[5]);
                it.ReservationTimeout = int.Parse(data[6]);
                it.NotReturnedTimeout = int.Parse(data[7]);
                it.OverdueTimeout = int.Parse(data[8]);

                for (int i = 9; i < data.Length; ++i)
                {
                    it.WaitingList.Add(int.Parse(data[i]));
                }
                Console.WriteLine(it);
                itemsList.Add(it);
            }
            return itemsList;
        }
        private void writeStudents()
        {
            var q = from Borrower b in borrowers
                    where b is Student
                    select b.ToString();

            File.WriteAllLines(studentsFile, q);
        }
        private void writeTeachers()
        {
            var q = from Borrower b in borrowers
                    where b is Teacher
                    select b.ToString();

            File.WriteAllLines(teachersFile, q);
        }
        private void writeItems()
        {
            var q = from Item i in items
                    select i.ToString();

            File.WriteAllLines(itemsFile, q);
        }
        public void SetTimeout(int index, int timeout)
        {
            string[] lines = File.ReadAllLines(timeoutsFile);
            lines[index] = lines[index].Split(',')[0] + "," + timeout;

            File.WriteAllLines(timeoutsFile, lines);
        }
        public int GetTimeout(int index)
        {
            string[] lines = File.ReadAllLines(timeoutsFile);
            return int.Parse(lines[index].Split(',')[1]);
        }
    }
}
