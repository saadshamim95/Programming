using Newtonsoft.Json;
using System;
using System.IO;

namespace Object_Oriented
{
    class AddressBook
    {
        public void operate() {
            Console.WriteLine("1: Insert into Address Book");
            Console.WriteLine("2: Update Existing Address Book");
            Console.WriteLine("3: Delete a Record from Address Book");
            Console.WriteLine("4: Display Address Book");
            Console.Write("Enter your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                    string stringResult = File.ReadAllText(@"C:\Users\ye10398\source\repos\saadshamim95\Programming\Object Oriented\Address_Book\AddressBook.json"); 
                    Modelling result = JsonConvert.DeserializeObject<Modelling>(stringResult);
                    foreach (Modelling.Item i in result.Records) {
                        Console.WriteLine();
                        Console.WriteLine("First Name: " + i.First);
                        Console.WriteLine("Last Name:  " + i.Last);
                        Console.WriteLine("Address:    " + i.Address);
                        Console.WriteLine("City:       " + i.City);
                        Console.WriteLine("State:      " + i.State);
                        Console.WriteLine("Zip:        " + i.Zip);
                        Console.WriteLine("Number:     " + i.Number);
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid Input!!!");
                    break;
            }
        }
    }
}