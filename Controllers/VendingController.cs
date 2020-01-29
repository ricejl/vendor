using System;
using vendor.Models;
using vendor.Services;

namespace vendor.Controllers
{
    class VendingController
    {
        private VendingService Service { get; set; } = new VendingService();
        private bool _running = true;


        public void Run()
        {
            Service.PrintSelection();

            while (_running)
            {
                PrintMessages();
                GetUserInput();
            }
            Console.Clear();
            System.Console.WriteLine("Have a great day!");
        }

        private void GetUserInput()
        {
            var key = Console.ReadLine().ToLower();
            Console.Clear();
            switch (key)
            {
                case "q":
                    _running = false;
                    break;
                case "quit":
                    _running = false;
                    break;
                case "d":
                    Service.DepositDollar();
                    break;
                case "deposit":
                    Service.DepositDollar();
                    break;
                default:
                    if (int.TryParse(key, out int num))
                    {
                        Service.PurchaseItem(num - 1);
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid command");
                        Service.PrintSelection();
                    }
                    break;
            }
        }

        public void PurchaseItem()
        {
            // take in item number
            // parse integer, pass on to service
        }

        private void PrintMessages()
        {
            foreach (string message in Service.Messages)
            {
                System.Console.WriteLine(message);
            }
            Service.Messages.Clear();
        }
    }
}