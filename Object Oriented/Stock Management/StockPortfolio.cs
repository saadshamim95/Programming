using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Object_Oriented
{
    class StockPortfolio
    {
        public void Test()
        {
            string strJSONResult = File.ReadAllText(@"C:\Users\Saad Shamim\Source\Repos\Programming\Object Oriented\Stock Management\Stock.json");
            List<Stock> stock = JsonConvert.DeserializeObject<List<Stock>>(strJSONResult);
            int totalValue = 0;
            Console.WriteLine("*************************Stock Management*************************");
            foreach (Stock item in stock)
            {
                int stockTotalValue = 0;
                stockTotalValue = item.Share_Price * item.Number_of_Shares;
                Console.WriteLine("Stock Name: " + item.Share_Name);
                Console.WriteLine("Share Price: " + item.Share_Price);
                Console.WriteLine("Number of Shares: " + item.Number_of_Shares);
                Console.WriteLine("Total Share Value: " + stockTotalValue);
                Console.WriteLine();
                totalValue += stockTotalValue;
            }
            Console.WriteLine("Total Value of all Stocks: " + totalValue);

            /*string strJsonResult = File.ReadAllText(@"C:\Users\Saad Shamim\source\repos\Programming\Object Oriented\StockTest.json");
            Stock stock = JsonConvert.DeserializeObject<Stock>(strJsonResult);
            PrintPrice(stock.Stock1List);
            PrintPrice(stock.Stock2List);
            PrintPrice(stock.Stock3List);*/
        }

        /*public void PrintPrice(List<Stock.Stock1> stock) {
            foreach (Stock.Stock1 item in stock) {
                Console.WriteLine("Stock Name: " + item.Share_Name);
                Console.WriteLine("Share Price: " + item.Share_Price);
                Console.WriteLine("Number of Shares: " + item.Number_of_Shares);
            }
        }*/
    }
}
