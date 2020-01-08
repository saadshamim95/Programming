using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Object_Oriented
{
    class InventoryManager
    {
        public void Test() {
            string strJsonResult = File.ReadAllText(@"C:\Users\Saad Shamim\Source\Repos\Programming\Object Oriented\Inventory Management\Inventory.json");
            Inventory result = JsonConvert.DeserializeObject<Inventory>(strJsonResult);
            PrintPrice(result.RiceList);
            PrintPrice(result.PulseList);
            PrintPrice(result.WheatList);
        }

        public void PrintPrice(List<Inventory.Rice> rice)
        {
            Console.WriteLine("********************Rice List********************");
            int total = 0;
            string str=String.Empty;
            foreach (Inventory.Rice i in rice) {
                str = "Name: " + i.Name + "\nWeight: " + i.Weight + "kg\nPrice: " + i.Price + "/kg\n";
                total += i.Price * i.Weight;
                Console.WriteLine(str);
            }
            Console.WriteLine("Total Value of Rice: " + total);
        }

        public void PrintPrice(List<Inventory.Wheat> wheat)
        {
            Console.WriteLine("\n********************Wheat List********************");
            int total = 0;
            string str = String.Empty;
            foreach (Inventory.Wheat i in wheat)
            {
                str = "Name: " + i.Name + "\nWeight: " + i.Weight + "kg\nPrice: " + i.Price + "/kg\n";
                total += i.Price * i.Weight;
                Console.WriteLine(str);
            }
            Console.WriteLine("Total Value of Wheat: " + total);
        }

        public void PrintPrice(List<Inventory.Pulse> pulse)
        {
            Console.WriteLine("\n********************Pulse List********************");
            int total = 0;
            string str = String.Empty;
            foreach (Inventory.Pulse i in pulse)
            {
                str = "Name: " + i.Name + "\nWeight: " + i.Weight + "kg\nPrice: " + i.Price + "/kg\n";
                total += i.Price * i.Weight;
                Console.WriteLine(str);
            }
            Console.WriteLine("Total Value of Pulse: " + total);
        }
    }
}