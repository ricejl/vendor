using System.Collections.Generic;
using vendor.Interfaces;

namespace vendor.Models
{
    class Machine
    {
        // holds list of IPurchasables and credit
        public float Credit { get; set; }
        public List<IPurchasable> Selection { get; set; } = new List<IPurchasable>();
        private void Setup()
        {
            Frozen burrito = new Frozen("Mega Bean Burrito", 2f, 40, 2021);
            Frozen rabbit = new Frozen("Roadkill Special Rabbit", 4f, 20, 2040);
            Candy twix = new Candy("Twix", 1f, false);
            Candy twizzlers = new Candy("Chocolate Twizzlers", 1.25f, false);
            Electronics headphones = new Electronics(false, "SkullCandy headphones", 20f);

            Selection.AddRange(new IPurchasable[]
            {
                burrito, rabbit, twix, twizzlers, headphones
            });
        }

        public Machine()
        {
            Setup();
        }
    }
}