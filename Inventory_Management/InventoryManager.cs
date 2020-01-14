using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Object_Oriented
{
    class InventoryManager
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test() {
            string strJsonResult = File.ReadAllText(@"C:\Users\ye10398\source\repos\saadshamim95\Programming\Object Oriented\Inventory_Management\Inventory.json");
            Inventory result = JsonConvert.DeserializeObject<Inventory>(strJsonResult);
            Console.WriteLine("****************************************");
            Console.WriteLine("               Rice List                ");
            Console.WriteLine("****************************************");
            int totalRiceValue = PrintPrice(result.RiceList);
            Console.WriteLine("Total Value of Rice: " + totalRiceValue);
            Console.WriteLine("****************************************");
            Console.WriteLine("               Pulse List               ");
            Console.WriteLine("****************************************");
            int totalPulseValue = PrintPrice(result.PulseList);
            Console.WriteLine("Total Value of Pulse: " + totalPulseValue);
            Console.WriteLine("****************************************");
            Console.WriteLine("               Wheat List               ");
            Console.WriteLine("****************************************");
            int totalWheatValue = PrintPrice(result.WheatList);
            Console.WriteLine("Total Value of Wheat: " + totalWheatValue);
        }

        /// <summary>
        /// Prints the price.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public int PrintPrice(List<Inventory.Item> item)
        {
            int total = 0;
            string str=String.Empty;
            foreach (Inventory.Item i in item) {
                str = "Name:   " + i.Name + "\nWeight: " + i.Weight + "kg\nPrice:  " + i.Price + "/kg\n";
                total += i.Price * i.Weight;
                Console.WriteLine(str);
            }
            return total;
        }
    }
}