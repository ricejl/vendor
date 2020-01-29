using vendor.Interfaces;

namespace vendor.Models
{
    abstract class Food : IPurchasable
    {
        protected Food(string title, float price)
        {
            Title = title;
            Price = price;
        }

        public string Title { get; set; }
        public float Price { get; set; }

        public string GetItem()
        {
            return $"{Title} - ${Price}";
        }
    }
}