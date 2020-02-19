using AutoMapper;
using System;

namespace AutoMapperTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            per.FirstName = "Saad";
            per.LastName = "Shamim";
            per.Salary = 10000;
            //// Creating Mapper
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Person, Employee>(); });
            IMapper mapper = config.CreateMapper(); 

            //// Using Mapper
            var employee = mapper.Map<Person, Employee>(per);
            Console.WriteLine("First Name: " + employee.FirstName);
            Console.WriteLine("Last Name: " + employee.LastName);
        }
    }
}
