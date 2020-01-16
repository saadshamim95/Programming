using System;
using System.IO;


namespace Object_Oriented
{
    class StockAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockAccount"/> class.
        /// </summary>
        public StockAccount() { 
        
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StockAccount"/> class.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public StockAccount(string fileName) {
            string path = @"C:\Users\ye10398\source\repos\saadshamim95\Programming\Object Oriented\Commercial_Data_Processing\" + fileName + ".json";
            File.Create(path);
            Console.WriteLine("File Created!!!");
        }

        /// <summary>
        /// Values the of.
        /// </summary>
        /// <returns></returns>
        public double valueOf() {
            double value = 0;
            return value;
        }

        /// <summary>
        /// Buys the specified amount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <param name="symbol">The symbol.</param>
        public void buy(int amount, string symbol) { 
        
        }

        /// <summary>
        /// Sells the specified amount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <param name="symbol">The symbol.</param>
        public void sell(int amount, string symbol) { 
        
        }

        /// <summary>
        /// Saves the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void save(string fileName) { 
        
        }

        /// <summary>
        /// Prints the report.
        /// </summary>
        public void printReport() { 
        
        }
    }
}