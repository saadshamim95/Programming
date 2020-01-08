using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class Week
    {
        public class WeekDay { 
            public string day;
            public string date;

            public WeekDay() { 
            
            }

            public WeekDay(string day,string date) {
                this.day = day;
                this.date = date;
            }

            public string getDay() {
                return this.day;
            }

            public string getDate() {
                return this.date;
            }
        }

        public void Test() {
            WeekDay obj1 = new WeekDay("S","");
            WeekDay obj2 = new WeekDay("M", "1");
            print(obj1);
            print(obj2);
        }

        public void print(WeekDay obj) {
            Console.WriteLine("Day: {0} Date: {1}",obj.day,obj.date);
        }
    }
}