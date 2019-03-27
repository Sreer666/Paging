using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PageingandSorting
{
    public class Student
    {
        public string Name { get; set; }

        public string StudentId { get; set; }

        public string TotalMarks { get; set; }


        public static List<Student> GetAllStudentInfo =
            new List<Student>()
            {
                new Student()
                {
                    Name= "Ramesh1",
                    StudentId= "1",
                    TotalMarks= "10"
                },
                new Student()
                {
                    Name= "Suresh1",
                    StudentId= "1",
                    TotalMarks= "10"
                },
                new Student()
                {
                    Name= "Akbar1",
                    StudentId= "1",
                    TotalMarks= "10"
                },
                new Student()
                {
                    Name= "Ramesh2",
                    StudentId= "2",
                    TotalMarks= "20"
                },
                new Student()
                {
                    Name= "Suresh2",
                    StudentId= "2",
                    TotalMarks= "20"
                },
                new Student()
                {
                    Name= "Akbar2",
                    StudentId= "2",
                    TotalMarks= "20"
                },
                new Student()
                {
                    Name= "Ramesh3",
                    StudentId= "3",
                    TotalMarks= "30"
                },
                new Student()
                {
                    Name= "Suresh3",
                    StudentId= "3",
                    TotalMarks= "30"
                },
                new Student()
                {
                    Name= "Akbar3",
                    StudentId= "3",
                    TotalMarks= "30"
                },
            };

    }
}