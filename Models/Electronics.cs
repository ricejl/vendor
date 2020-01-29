using vendor.Interfaces;

namespace vendor.Models
{
    class Electronics : IPurchasable
    {
        public Electronics(bool includesBatteries, string title, float price)
        {
            IncludesBatteries = includesBatteries;
            Title = title;
            Price = price;
        }

        public bool IncludesBatteries { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }

        public string GetItem()
        {
            if (IncludesBatteries)
            {
                return $"{Title} - {Price} (batteries included)";
            }
            else
            {
                return $"{Title} - {Price} (batteries not included)";
            }
        }
    }
}