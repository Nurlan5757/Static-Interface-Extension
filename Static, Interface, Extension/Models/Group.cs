using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Interface__Extension.Models
{
    internal class Group
    {
        static int GroupCount = 0;

        static Group[] Groups { get; set; }= new Group[0];     
        public int GroupId { get; set; }= 0;
        public string GroupName { get; set; }
        Student[] Students { get; set; }= new Student[0];


        public Group(Student[] Students)
        {
            
        }

        public string GetGroupInfo()
        {
            return $"GroupId:{GroupId}  GroupName:{GroupName}";
        }

        public Student GetStudent(int id)
        {
            foreach (Student students in Students)
            {
                if(students.Id == id) return students;
            }
            return null;
        }

        public void AddStudent(Student student)
        {
           /* Array.Resize(ref Student, Students.Length + 1);
            Students[Students.Length - 1] = student;*/
        }
        public void Search()
        {

        }
        public void ShowStudents()
        {

        }
        public void ToString()
        {

        }

        /*static AddGroup()
        {

        }*/




    }
}
