using System;

namespace DZ.Classes
{
    [Serializable]
    public class Shop
    {
        public string name;
        public string address;
        public string timeOfWork;
        public int numbOfTicket;
        public int priceOfTicket;
        public Shop() { }
        public Shop(string name, string address, string timeOfWork, int numbOfTicket, int priceOfTicket)
        {
            this.name = name;
            this.address = address;
            this.timeOfWork = timeOfWork;
            this.numbOfTicket = numbOfTicket;
            this.priceOfTicket = priceOfTicket;
        }
    }
}
