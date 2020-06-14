using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryBorrowSystem.Model
{

    public enum Category
    {
        CD, Book
    }
    public enum State
    {
        Available, Reserved, Unavailable
    }

    public class Item
    {
        private List<int> waitingList; // borrower IDs
        private int itemId;
        private string name;
        private Category category;
        private double price;
        private State state;
        private int reservationTimeout;
        private int notReturnedTimeout;
        private int overdueTimeout;
        private int borrowerId;

        public Item()
        {
            this.waitingList = new List<int>();
        }

        public Item(int itemId, string name, Category category, double price, State state, int reservationTimeout, int notReturnedTimeout, int overdueTimeout)
        {
            this.waitingList = new List<int>();
            this.itemId = itemId;
            this.name = name;
            this.category = category;
            this.price = price;
            this.state = state;
            this.reservationTimeout = reservationTimeout;
            this.notReturnedTimeout = notReturnedTimeout;
            this.overdueTimeout = overdueTimeout;
        }

        public List<int> WaitingList { get => waitingList; set => waitingList = value; }
        public int ItemId { get => itemId; set => itemId = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int ReservationTimeout { get => reservationTimeout; set => reservationTimeout = value; }
        public int NotReturnedTimeout { get => notReturnedTimeout; set => notReturnedTimeout = value; }
        public int OverdueTimeout { get => overdueTimeout; set => overdueTimeout = value; }
        public Category Category { get => category; set => category = value; }
        public State State { get => state; set => state = value; }
        public int BorrowerId { get => borrowerId; set => borrowerId = value; }

        public void CheckTimeouts(Controller.DataRepository dataRepository)
        {
            if (state == State.Reserved && reservationTimeout > 0)
            {
                reservationTimeout--;

                if (reservationTimeout == 0)
                {
                    
                    if (waitingList.Count > 0)
                    {
                        waitingList.Remove(waitingList.First());
                        if (waitingList.Count > 0)
                        {
                            Borrower borrower = dataRepository.GetBorrower(waitingList.First());
                            reservationTimeout = dataRepository.GetTimeout(0);
                            string subject = "Item Reserved";
                            string body = string.Format("Dear {0},\r\n\r\nThe item {1} has been reserved for you.\r\nYou have {2} hours to borrow it.", borrower.Name, name, reservationTimeout / 60);
                            new Thread(() => new Controller.MessageSender().SendEmail(borrower.Email, subject, body)).Start();
                        }
                        else
                        {
                            state = State.Available;
                        }
                    }
                    else
                    {
                        state = State.Available;
                    }
                }

            }
            else if (state == State.Unavailable && notReturnedTimeout > 0)
            {
                notReturnedTimeout--;

                if (notReturnedTimeout == 0)
                {
                    Borrower borrower = dataRepository.GetBorrower(borrowerId);
                    string subject = "Item Borrow Period Ended";
                    string body = string.Format("Dear {0},\r\n\r\nYou have passed the due time for returning the item {1}.\r\nYou have {2} hours to return it, or you will be charged three times its actual price.", borrower.Name, name, overdueTimeout / 60);
                    new Thread(() => new Controller.MessageSender().SendEmail(borrower.Email, subject, body)).Start();
                }

            }
            else if (state == State.Unavailable && notReturnedTimeout <=0 && overdueTimeout > 0)
            {
                overdueTimeout--;

                if (overdueTimeout == 0)
                {
                    Borrower borrower = dataRepository.GetBorrower(borrowerId);
                    string subject = "Final Item Return Period Ended";
                    string body = string.Format("Dear {0},\r\n\r\nThe item {1} has been overdue beyond the allowed time.\r\nYou have been charged {2}JD.", borrower.Name, name, price*3);
                    new Thread(() => new Controller.MessageSender().SendEmail(borrower.Email, subject, body)).Start();
                }

            }
        }

        public override bool Equals(object obj)
        {
            return obj is Item && this.itemId == (obj as Item).itemId;
        }
        public override string ToString()
        {
            string str = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}", itemId, name, category, price, state, borrowerId, reservationTimeout, notReturnedTimeout, overdueTimeout);
            for (int i = 0; i < waitingList.Count; ++i)
            {
                str += "," + waitingList[i];
            }
            return str;
        }
    }
}
