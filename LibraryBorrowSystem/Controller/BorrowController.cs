using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryBorrowSystem.Controller
{
    public class BorrowController
    {

        DataRepository dataRepository = new DataRepository();
        MessageSender messageSender = new MessageSender();
        Thread timer;

        public BorrowController()
        {
            try
            {
                timer = new Thread(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(60000);
                        Tick();
                    }
                });
                timer.Start();
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine("Terminating...");
            }
        }
        public void Terminate()
        {
            timer.Abort();
        }
        public Model.Borrower GetBorrower(int borrowerId)
        {
            return dataRepository.GetBorrower(borrowerId);
        }
        public Model.Item GetItem(int itemId)
        {
            return dataRepository.GetItem(itemId);
        }
        public void Borrow(int borrowerId, int itemId)
        {
            Model.Borrower borrower = dataRepository.GetBorrower(borrowerId);
            Model.Item item = dataRepository.GetItem(itemId);
            
            borrower.BorrowedItems.Add(item.ItemId);
            item.State = Model.State.Unavailable;
            item.BorrowerId = borrower.Id;
            item.WaitingList.Remove(borrower.Id);
            item.ReservationTimeout = GetTimeout(0);
            item.NotReturnedTimeout = GetTimeout(1);
            item.OverdueTimeout = GetTimeout(2);
            dataRepository.SetItem(item);
            dataRepository.SetBorrower(borrower);
        }

        public void Reserve(int borrowerId, int itemId)
        {
            Model.Borrower borrower = dataRepository.GetBorrower(borrowerId);
            Model.Item item = dataRepository.GetItem(itemId);

            item.WaitingList.Add(borrower.Id);
            dataRepository.SetItem(item);
            dataRepository.SetBorrower(borrower);
        }

        public List<Model.Borrower> GetAllBorrowers()
        {
            return dataRepository.GetAllBorrowers();
        }

        public void ReturnItem(int borrowerId, int itemId)
        {
            Model.Borrower borrower = dataRepository.GetBorrower(borrowerId);
            Model.Item item = dataRepository.GetItem(itemId);

            borrower.BorrowedItems.Remove(item.ItemId);
            item.BorrowerId = 0;
            if (item.WaitingList.Count > 0)
            {
                Model.Borrower first = dataRepository.GetBorrower(item.WaitingList.First());
                item.WaitingList.Remove(first.Id);
                item.State = Model.State.Reserved;
                string subject = "Item Available";
                string body = string.Format("Dear {0},\r\n\r\nThe item {1} was returned and it has been reserved for you.\r\nYou have {2} hours to borrow the item.", first.Name, item.Name, item.ReservationTimeout/60);
                new Thread(() => messageSender.SendEmail(first.Email, subject, body)).Start();
            }
            else
            {
                item.State = Model.State.Available;
            }
            item.ReservationTimeout = GetTimeout(0);
            item.NotReturnedTimeout = GetTimeout(1);
            item.OverdueTimeout = GetTimeout(2);
            dataRepository.SetItem(item);
            dataRepository.SetBorrower(borrower);
        }
        public List<Model.Item> GetAllItems()
        {
            return dataRepository.GetAllItems();
        }
        public List<Model.Item> GetLateItems()
        {
            return dataRepository.GetLateItems();
        }
        public List<Model.Item> GetItems(int borrowerId)
        {
            return dataRepository.GetItems(borrowerId);
        }
        public bool AddItem(Model.Item item)
        {
            return dataRepository.AddItem(item);
        }
        public bool RemoveItem(int itemId)
        {
            GetBorrower(GetItem(itemId).BorrowerId).BorrowedItems.Remove(itemId);
            return dataRepository.RemoveItem(itemId);
        }
        public bool AddBorrower(Model.Borrower borrower)
        {
            return dataRepository.AddBorrower(borrower);
        }
        public bool RemoveBorrower(int borrowerId)
        {
            foreach (int i in GetBorrower(borrowerId).BorrowedItems)
            {
                dataRepository.RemoveItem(i);
            }
            return dataRepository.RemoveBorrower(borrowerId);
        }
        public void SetTimeout(int index, int timeout)
        {
            dataRepository.SetTimeout(index, timeout);
        }
        public int GetTimeout(int index)
        {
            return dataRepository.GetTimeout(index);
        }
        public void Tick()
        {
            Thread timeoutChecker = new Thread(() =>
            {
                var items = dataRepository.GetAllItems();
                items.ForEach(i => i.CheckTimeouts(dataRepository));
            });
            timeoutChecker.Start();
        }
        public void SaveData()
        {
            dataRepository.WriteData();
        }
    }
}
