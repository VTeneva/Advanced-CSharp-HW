using System.Collections.Generic;

namespace _01.Class_Student
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string firstname, string lastName, int age, int facNum, string phone, 
            string email, IList<int> marks, int grNum)
        {
            this.FirstName = firstname;
            this.LastName = LastName;
            this.Age = age;
            this.FacultyNumber = facNum;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = grNum;
        }
    }
}
