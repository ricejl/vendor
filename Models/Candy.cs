using vendor.Interfaces;

namespace vendor.Models
{
    class Candy : Food
    {
        public Candy(string title, float price, bool hasNuts) : base(title, price)
        {
            HasNuts = hasNuts;
        }

        public bool HasNuts { get; set; }
    }
}