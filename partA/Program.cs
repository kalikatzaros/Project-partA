using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partA
{
    class Program
    {
        static void Main(string[] args)
        {

            var student1 = new Student() {
                FirstName = "Hey",
                LastName = "Hi",
                //year, month, and day
                DateOfBirth = new DateTime(1985, 3, 22),
                TuitionFees=120.5
            };

            var student2 = new Student()
            {
                FirstName = "fizz",
                LastName = "buzz",
                //year, month, and day
                DateOfBirth = new DateTime(1985, 4, 22),
                TuitionFees=456
            };

            var student3 = new Student()
            {
                FirstName = "pina",
                LastName = "colada",
                //year, month, and day
                DateOfBirth = new DateTime(1985, 4, 21),
                TuitionFees=230.5
            };

            Menu.AllStudents.Add(student1);
            Menu.AllStudents.Add(student2);
            Menu.AllStudents.Add(student3);

            var course1 = new Course()
            {
                Title="Web Development",
                Type=(CourseType)1,
                Stream="C#",
                StartDate=new DateTime(2022,4,23),
                EndDate= new DateTime(2022, 6, 23)
            };

            var course2 = new Course()
            {
                Title = "Web Development 2",
                Type = (CourseType)1,
                Stream = "Javascript",
                StartDate = new DateTime(2022, 4, 23),
                EndDate = new DateTime(2022, 6, 23)
            };

            var trainer = new Trainer()
            {
                FirstName = "Giwrgos",
                LastName = "Pasparakhs",
                Subject = "Talking to the compiler"
            };

            var trainer2= new Trainer()
            {
                FirstName = "Panos",
                LastName = "Bozas",
                Subject = "Coding - Stage1..StageN"
            };

            var trainer3 = new Trainer()
            {
                FirstName = "I am the Best",
                LastName = "Soldier",
                Subject = "Presenting Pdfs"
            };
            course2.Students.Add(student1);
            course1.Students.Add(student2);
            course2.Students.Add(student3);
            Menu.AllTrainers.Add(trainer);
            Menu.AllTrainers.Add(trainer2);
            Menu.AllTrainers.Add(trainer3);
            Menu.AllCourses.Add(course1);
            Menu.AllCourses.Add(course2);

            Menu.DisplayMenu();
        }
    }
}
