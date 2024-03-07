using System;

namespace DZ.Classes
{
    [Serializable]
    public class Prize
    {
        public string mainPrice;
        public string priceOfTicket = "Цена за билет - ";
        public double chance;
        public int circulation;
        public int number;

        public Prize() { }
        public Prize(string mainPrice, string priceOfTicket, double chance, int circulation, int number)
        {
            this.mainPrice = mainPrice;
            this.priceOfTicket = priceOfTicket;
            this.chance = chance;
            this.number = number;
            this.circulation = circulation;
        }

    }
}
