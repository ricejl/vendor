using System;
using vendor.Controllers;

namespace vendor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            VendingController vc = new VendingController();
            vc.Run();
        }
    }
}
