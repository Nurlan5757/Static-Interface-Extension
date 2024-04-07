using Static__Interface__Extension.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Interface__Extension.Models
{
    internal class Student
    {
        static int count = 0;
        public int Id { get; set; }
        public string Name { get ; set; }
        public string Surname { get; set; }


        public Student(string name, string surname)
        {
            Name = name.Capitalize();
            Surname = surname.Capitalize();
            Id = count++;
        }

        public string GetInfo()
        {
            return $"{Name} {Surname}";
        }

    }
}
