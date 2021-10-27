using System;
using System.Collections.Generic;

namespace _06._Store_Boxes
{
    class Program
    {
        public static string Serialnumber { get; private set; }

        static void Main(string[] args)
        {
            List<string> array = new List<string>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] tokens = command.Split(" ");
                
                string serialNumber = tokens[0];
                string item = tokens[1];
                int quanity = int.Parse(tokens[2]);
                decimal price = decimal.Parse(tokens[3]);
              



                 command = Console.ReadLine();
            }

        }

        
    }
    class Item
    {
        string Name { get; set; }
        string Price { get; set; }
    }
    class Box
    {
        public Box()
        {
            Item = new Item();

        }
        public string Serialnumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuanity { get; set; }
        public decimal PriceForBox { get; set; }

    }


}
