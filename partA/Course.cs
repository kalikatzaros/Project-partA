using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partA
{
    enum CourseType { partTime=1,fullTime=2}
    class Course
    {
        public string Title { get; set; }
        public CourseType Type { get; set; }
        public string Stream { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public Course()
        {

        }

        public Course(string title, CourseType type, string stream, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Type = type;
            Stream = stream;
            StartDate = startDate;
            EndDate = endDate;
        }
        
         public void AddStudents()
        {
            Console.Clear();
            Console.WriteLine($"****** Add Student(s) to {Title} {Stream}******\b");
            Console.WriteLine("Enter the number of each student you want to add");
            Console.WriteLine("Press -1 to exit\b");
            Menu.ListAllStudents();
            Console.WriteLine("\bEnter Student(s) Number:");
            var selection = Convert.ToInt32(Console.ReadLine());
           
            while (selection != -1)
            {
                Students.Add(Menu.AllStudents[selection]);
                selection = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{Menu.AllStudents[selection].Fullname} succesfully added to {Title} {Stream}.");
            }
            if (selection == -1)
            {
                Console.Clear();
                Menu.DisplayCoursesMenu();
            }

        }
        public void AddTrainers()
        {
            Console.Clear();
            Console.WriteLine($"****** Add Trainer(s) to {Title} {Stream}******\b");
            Console.WriteLine("Enter the number of each trainer you want to add");
            Console.WriteLine("Press -1 to exit\b");
            Menu.ListAllTrainers();
            Console.WriteLine("\bEnter Trainer(s) Number:");
            var selection = Convert.ToInt32(Console.ReadLine());
            while (selection !=-1)
            {
                Trainers.Add(Menu.AllTrainers[selection]);
                selection = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{Menu.AllTrainers[selection].Fullname} succesfully added to {Title} {Stream}.");
            }
            if (selection == -1)
            {
                Console.Clear();
                Menu.DisplayTrainersMenu();
            }

        }
        public void AddAssignments()
        {
            Console.Clear();
            Console.WriteLine($"****** Add Assignment(s) to {Title} {Stream}******\b");
            Console.WriteLine("Enter the number of each trainer you want to add");
            Console.WriteLine("Press -1 to exit\b");
            Menu.ListAllTrainers();
            Console.WriteLine("\bEnter Assignment(s) Number:");
            var selection = Convert.ToInt32(Console.ReadLine());
            while (selection != -1)
            {
                Assignments.Add(Menu.AllAssignments[selection]);
                selection = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{Menu.AllAssignments[selection].Title} succesfully added to {Title} {Stream}.");
            }
            if (selection == -1)
            {
                Console.Clear();
                Menu.DisplayCoursesMenu();
            }

        }
        public void ListStudents()
        {
            Console.Clear();
            Console.WriteLine($"Students of Course {Title}");
            int counter = 0;
            foreach (var student in Students)
            {
                Console.WriteLine($"{counter}.\t{student.Fullname}");
                counter++;
            }
            Console.WriteLine("\b");
        }

        public void ListTrainers()
        {
            Console.Clear();
            Console.WriteLine($"Trainers of Course {Title}");
            int counter = 0;
            foreach (var trainer in Trainers)
            {
                Console.WriteLine($"{counter}.\t{trainer.Fullname}");
                counter++;
            }
            Console.WriteLine("\b");
        }
        public void ListAssignments()
        {
            Console.Clear();
            Console.WriteLine($"Assignments of Course {Title}");
            int counter = 0;
            foreach (var assignment in Assignments)
            {
                Console.WriteLine($"{counter}.\t{assignment.Title}");
                counter++;
            }
            Console.WriteLine("\b");
        }
    }
}
