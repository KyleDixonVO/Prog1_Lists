using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");
            Console.WriteLine("(inventory1 System)");
            Console.WriteLine();

            string currentItem;
            string[] inventory1 = new string[10];

            currentItem = "health potion";
            for (int i = 0; i <= inventory1.Length - 1; i++)
            {
                inventory1[i] = "";
            }

            inventory1[0] = "health potion"; // works but could overlap if zero is already taken


            Console.WriteLine("Lists");
            Console.WriteLine("(Inventory System)");
            Console.WriteLine();

            List<string> inventory = new List<string>();
            // declaration
            //                          instantiation

            Console.WriteLine("intventory size = " + inventory.Count);
            inventory.Add("health potion");
            Console.WriteLine("intventory size = " + inventory.Count);
            inventory.Add("health potion");
            Console.WriteLine("intventory size = " + inventory.Count);
            //shows inventory size (amount of items)

            Console.WriteLine(inventory[1]);

            for (int j = 0; j <= inventory.Count - 1; j++)
            {
                Console.WriteLine(inventory[j]);
            }

            foreach (string item in inventory)
            {
                Console.WriteLine(item);
            }

            inventory.Remove("health potion");
            Console.WriteLine("inventory");
            foreach (string item in inventory)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
