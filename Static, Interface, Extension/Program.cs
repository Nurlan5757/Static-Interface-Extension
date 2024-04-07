using Static__Interface__Extension.Extension;
using Static__Interface__Extension.Models;

namespace Static__Interface__Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string name = "nUrLan";
             string surname = "aBBaSov";*/

            Helper.IsOdd(23);
            Helper.IsEven(22);
            Helper.HasDigit("salam");
            Helper.CheckPassword("113243");
            /*Helper.Capitalize();*/



            Student student = new Student("nUrLan", "aBBaSov");
            Console.WriteLine($"{student.Name} {student.Surname}");

           /* Group[] Groups = new Group[] { "AB106", "CD102" };*/

        }
    }
}
