using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

// All homework problems are coded in this class.

namespace _01.Class_Student
{
    class ClassStudent
    {
        public static void Main()
        {          
            var studentOne = new Student("John", "Smith", 18, 12345, "+44471234", "smith.john@yahoo.com", new[] {4,5,6}, 2);
            var studentTwo = new Student("Annie", "Jones", 27, 55555, "+44912652", "annie@gmail.com", new[] { 6, 6, 6 }, 1);
            var studentThree = new Student("Bobby", "Jones", 20, 45678, "+9981626", "bob@mail.com", new[] { 3,3,5 }, 2);
            var students = new[] { studentOne, studentTwo, studentThree };

            //Problem 2.	Students by Group
            Console.WriteLine("Problem 2.	Students by Group");
            var isGroupTwo = 
                from stud in students
                where stud.GroupNumber == 2
                select stud ;

            foreach (var stud in isGroupTwo)
            {
                Console.WriteLine(stud.FirstName);
            }

            //Problem 3.	Students by First and Last Name
            Console.WriteLine("Problem 3.	Students by First and Last Name");
            var firstNameBeforeLast = students.
                Where(student => student.FirstName.CompareTo(student.LastName) < 0).
                Select(student => student);

            foreach (var stud in firstNameBeforeLast)
            {
                Console.WriteLine(stud.FirstName);
            }

            //Problem 4.	Students by Age
            Console.WriteLine("Problem 4.	Students by Age");
            var ageBetween = students.
                Where(student => student.Age <= 24).
                Select(student => student);

            foreach (var stud in ageBetween)
            {
                Console.WriteLine("{0}, {1}, {2}", stud.FirstName, stud.LastName, stud.Age);
            }
        }
    }
}