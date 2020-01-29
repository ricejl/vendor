using System.Collections.Generic;
using vendor.Models;

namespace vendor.Services
{
    class VendingService
    {
        private Machine VendingMachine = new Machine();
        public List<Message> Messages = new List<Message>();
        public void PrintSelection()
        {
            Messages.Add(new Message("--- Today's Selection ---"));
            int index = 1;
            foreach (var item in VendingMachine.Selection)
            {
                Messages.Add(new Message(index.ToString() + ") " + item.GetItem()));
                index++;
            }
            Messages.Add(new Message("\nEnter (d) to deposit a dollar, the number of the item you'd like to purchase, or (q) to quit"));
        }

        public void DepositDollar()
        {
            VendingMachine.Credit++;
            Messages.Add(new Message($"Total credit: ${VendingMachine.Credit}\n"));
            PrintSelection();
        }

        public void PurchaseItem(int num)
        {
            if (num < 0 || num >= VendingMachine.Selection.Count)
            {
                Messages.Add(new Message("Invalid selection number"));
                PrintSelection();
                return;
            }
            else if (VendingMachine.Selection[num].Price > VendingMachine.Credit)
            {
                Messages.Add(new Message("You do not have enough to purchase this item. Please deposit more money.\n"));
                PrintSelection();
                return;
            }
            VendingMachine.Credit = VendingMachine.Credit - VendingMachine.Selection[num].Price;
            Messages.Add(new Message($"Remaining credit: ${VendingMachine.Credit}\nEnjoy your {VendingMachine.Selection[num].Title}!\n"));
            PrintSelection();
        }
    }

}