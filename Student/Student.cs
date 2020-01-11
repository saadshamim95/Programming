using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Hobbies { get; set; }

        public override string ToString()
        {
            return String.Format("Id: {0},\nName: {1},\nHobbies: {2}", Id, Name, string.Join(",", Hobbies.ToArray()));
        }
    }
}