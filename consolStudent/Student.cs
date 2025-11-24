using System;
using System.Collections.Generic;
using System.Text;

namespace consolStudent
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Studieprogram { get; set; }
        public int StudentID { get; set; }

        public Student(string name, int age, string studieprogram, int studentID)
        {
            Name = name;
            Age = age;
            Studieprogram = studieprogram;
            StudentID = studentID;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {Name}, alder {Age}, studenid:{StudentID}, studie program{Studieprogram}");
        }
    }
}
