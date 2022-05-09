using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partA
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double TuitionFees { get; set; }
        public List<Assignment> Assignments = new List<Assignment>();
        public Dictionary<Course,Assignment> AssignmentsPerCourse { get; set; } = new Dictionary<Course,Assignment>();
        public string Fullname
        {
            get { return $"{FirstName} {LastName}"; }
            
        }

        public Student()
        {
                
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, double tuitionFees)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
        }

       public void EditStudent()
        {
           
            Console.WriteLine("******** Edit Student **********");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine("--Edit First Name:");
            string firstName = Console.ReadLine();
            FirstName = (firstName == string.Empty) ? FirstName : firstName;
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine("--Edit Last Name:");
            string lastName = Console.ReadLine();
            LastName = (lastName == string.Empty)?LastName:lastName;
            Console.WriteLine($"Date Of Birth: {DateOfBirth}");
            Console.WriteLine("Edit Date Of Birth:");
            try { 
                DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
                DateOfBirth = dateOfBirth;
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Date");
                DateOfBirth = DateOfBirth;
            }
            Console.WriteLine($"Tuition Fees: {TuitionFees}");
            Console.WriteLine("Edit Tuition Fees:");
            try
            {
                double tuitionFees = Convert.ToDouble(Console.ReadLine());
                TuitionFees = tuitionFees;
            }
            catch(Exception e)
            {
                TuitionFees = TuitionFees;
            }
            Console.Clear();
            Console.WriteLine($"Student: {Fullname} succesfully edited!");
        }
        public void ListAssignments()
        {
            Console.Clear();
            Console.WriteLine($"Assignments of Student {Fullname}");
            int counter = 0;
            foreach (var assignment in Assignments)
            {
                Console.WriteLine($"{counter}.\t{assignment.Title}");
                counter++;
            }
            Console.WriteLine("\b");
        }
        public void AddAssignment()
        {
            Menu.ListAllCourses();
            Console.WriteLine("Choose course: enter course's number:");
            var index = Convert.ToInt32(Console.ReadLine());
            var course = Menu.AllCourses[index];
            course.ListAssignments();
            Console.WriteLine($"Enter the number of the assignment you want to add to student {Fullname}");
            index = Convert.ToInt32(Console.ReadLine());
            Assignments.Add(course.Assignments[index]);
        }
    }
}
