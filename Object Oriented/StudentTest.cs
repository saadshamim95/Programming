using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Object_Oriented
{
    class StudentTest
    {
        public void Test() {
            Student student = new Student()
            {
                Id = 1,
                Name = "Saad Shamim",
                Hobbies = new List<string>() {
                "Watching Sports",
                "Playing Games"
            }
            };

            string strJSONResult = JsonConvert.SerializeObject(student);
            
            File.WriteAllText(@"C:\Users\Saad Shamim\source\repos\Programming\Object Oriented\student.json", strJSONResult);
            Console.WriteLine("Stored!!!");

            strJSONResult = File.ReadAllText(@"C:\Users\Saad Shamim\source\repos\Programming\Object Oriented\student.json");

            Student result = JsonConvert.DeserializeObject<Student>(strJSONResult);
            Console.WriteLine(result.ToString());
        } 
    }
}