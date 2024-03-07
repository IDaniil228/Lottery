using System;

namespace DZ
{
    [Serializable]
    public class Organ
    {
        public string name;
        public string price;
        public string maxPrize;
        public string numOfTickets;
        public int number;

        public Organ() { }
        public Organ(string name, string price, string maxPrize, string numOfTickets, int number)
        {
            this.name = name;
            this.price = "Цена за билет - " + price;
            this.maxPrize = "Максимальный приз - " + maxPrize;
            this.number = number;
            this.numOfTickets = "Кол-во билетов - " + numOfTickets;
        }

    }
}
