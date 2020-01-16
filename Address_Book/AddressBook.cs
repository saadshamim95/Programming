using System;

namespace Object_Oriented
{
    class AddressBook
    {
        private string fileAddress = @"C:\Users\ye10398\source\repos\saadshamim95\Programming\Object Oriented\Address_Book\AddressBook.json";

        /// <summary>
        /// Operates this instance.
        /// </summary>
        public void operate() {
            Console.WriteLine("1: Insert Records into Address Book");
            Console.WriteLine("2: Update Existing Records in Address Book");
            Console.WriteLine("3: Delete a Record from Address Book");
            Console.WriteLine("4: Display Address Book");
            Console.Write("Enter your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                    AddRecord addRecord = new AddRecord();
                    addRecord.add(fileAddress);
                    break;
                case 2:
                    UpdateRecord updateRecord = new UpdateRecord();
                    updateRecord.update(fileAddress);
                    break;
                case 3:
                    DeleteRecord deleteRecord = new DeleteRecord();
                    deleteRecord.delete(fileAddress);
                    break;
                case 4:
                    DisplayRecords records = new DisplayRecords();
                    records.display(fileAddress);
                    break;
                default:
                    Console.WriteLine("Invalid Input!!!");
                    break;
            }
        }
    }
}