using vendor.Interfaces;

namespace vendor.Models
{
    class Frozen : Food
    {
        //constructor
        public Frozen(string title, float price, int temp, int expirationYear) : base(title, price)
        {
            Temp = temp;
            ExpirationYear = expirationYear;
        }

        public int Temp { get; set; }
        public int ExpirationYear { get; set; }
    }
}