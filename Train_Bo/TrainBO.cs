using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Bo
{
    public class TrainBO
    {

        int trainId;

        public int TrainId
        {
            get { return trainId; }
            set { trainId = value; }
        }

        string trainName;

        public string TrainName
        {
            get { return trainName; }
            set { trainName = value; }
        }

        string source;

        public string Source
        {
            get { return source; }
            set { source = value; }
        }

        string destination;

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        double ticketFare;

        public double TicketFare
        {
            get { return ticketFare; }
            set { ticketFare = value; }
        }

        double ticketAmount;

        public double TicketAmount
        {
            get { return ticketAmount; }
            set { ticketAmount = value; }
        }

        int bookId;

        public int BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        double contactNo;

        public double ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; }
        }


        int noOftickets;

        public int NoOftickets
        {
            get { return noOftickets; }
            set { noOftickets = value; }
        }

    }
}
