using System;

namespace vendor.Models
{
    class Message
    {
        public string Body { get; set; }
        public ConsoleColor Color { get; set; }

        public void Print()
        {
            Console.ForegroundColor = Color;
            // Console.BackgroundColor = ConsoleColor.Green;
            System.Console.WriteLine(Body);
        }

        public Message(string body)
        {
            Body = body;
        }

        public Message(string body, ConsoleColor color)
        {
            Body = body;
            Color = color;
        }
    }
}