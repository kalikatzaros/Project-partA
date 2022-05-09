using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace partA
{
    static class Menu
    {
        public static List<Course> AllCourses { get; set; } = new List<Course>();
        public static List<Student> AllStudents { get; set; } = new List<Student>();
        public static List<Trainer> AllTrainers { get; set; } = new List<Trainer>();
        public static List<Assignment> AllAssignments { get; set; } = new List<Assignment>();

        public static void ListAllCourses()
        {
            int counter = 0;
            Console.WriteLine("*********** All  Available Courses *********");
            Console.WriteLine("\b");
            foreach (var course in AllCourses)
            {
                Console.WriteLine($"{counter}.\t {course.Title}\t {course.Stream}");
                counter++;
            }
            Console.WriteLine("\b");
        }
        public static void ListAllStudents()
        {
            int counter = 0;
            Console.WriteLine("*********** All Available Students *********");
            Console.WriteLine("\b");
            foreach (var student in AllStudents)
            {

                Console.WriteLine($"{counter}.\t {student.Fullname}\t{student.DateOfBirth.ToString("d/M/yy")}\t {student.TuitionFees}");
                counter++;
            }
            Console.WriteLine("\b");
        }
        public static void ListAllTrainers()
        {
            int counter = 0;
            Console.WriteLine("*********** All Available Trainers *********");
            Console.WriteLine("\b");
            foreach (var trainer in AllTrainers)
            {
                Console.WriteLine($"{counter}.\t {trainer.Fullname}\t{trainer.Subject}");
                counter++;
            }
            Console.WriteLine("\b");

        }
        public static void ListAllAssignments()
        {
            int counter = 0;
            Console.WriteLine("*********** All Available Assignments *********");
            Console.WriteLine("\b");
            foreach (var assignment in AllAssignments)
            {
                Console.WriteLine($"{counter}.\t {assignment.Title}");
                counter++;
            }
            Console.WriteLine("\b");
        }
        public static void DisplayMenu()
        {
            Console.WriteLine("**********Coding School***************");
            Console.WriteLine("For Courses menu \t press 1");
            Console.WriteLine("For Students menu \t press 2");
            Console.WriteLine("For Trainers menu \t press 3");
            Console.WriteLine("For Assignments menu \t press 4");
            Console.WriteLine("To Exit\t \t\t press Escape");
            Console.WriteLine("***************************************");
            Console.WriteLine("Enter Selection:");
            var userSelection = Console.ReadKey();


            while (userSelection.Key != ConsoleKey.D1 && userSelection.Key != ConsoleKey.D2 && userSelection.Key != ConsoleKey.D3 && userSelection.Key != ConsoleKey.D4 && userSelection.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Please Provide a valid option ");
                userSelection = Console.ReadKey();
            }

            switch (userSelection.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    DisplayCoursesMenu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    DisplayStudentsMenu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    DisplayTrainersMenu();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    DisplayAssignmentsMenu();
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }

        }

        public static void DisplayCoursesMenu()
        {
            Console.WriteLine("**********Courses**********************");
            Console.WriteLine("List All Courses \t\t press 1");
            Console.WriteLine("Add Course(s) \t\t\t press 2");
            Console.WriteLine("Add Student(s) to Course \t press 3");
            Console.WriteLine("Add Trainer(s) to Course \t press 4");
            Console.WriteLine("Add Assignment(s) to Course \t press 5");
            Console.WriteLine("To Go Back \t\t\t press Escape");
            Console.WriteLine("***************************************");
            Console.WriteLine("Enter Selection:");
            var userSelection = Console.ReadKey();
            while (userSelection.Key != ConsoleKey.D1 && userSelection.Key != ConsoleKey.D2 && userSelection.Key != ConsoleKey.D3 && userSelection.Key != ConsoleKey.D4 && userSelection.Key != ConsoleKey.D5 && userSelection.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Please Provide a valid option ");
                userSelection = Console.ReadKey();
            }

            switch (userSelection.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    ListAllCourses();
                    DisplayCoursesMenu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    AddCourse();
                    DisplayCoursesMenu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine("****** Choose Course ********\b");
                    ListAllCourses();
                    var course = Convert.ToInt32(Console.ReadLine());
                    AllCourses[course].AddStudents();
                    DisplayCoursesMenu();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine("****** Choose Course ********\b");
                    ListAllCourses();
                    course = Convert.ToInt32(Console.ReadLine());
                    AllCourses[course].AddTrainers();
                    ListAllTrainers();
                    DisplayCoursesMenu();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    Console.WriteLine("****** Choose Course ********\b");
                    ListAllCourses();
                    course = Convert.ToInt32(Console.ReadLine());
                    AllCourses[course].AddAssignments();
                    Console.Clear();
                    DisplayCoursesMenu();
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    DisplayMenu();
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }
        public static void DisplayStudentsMenu()
        {
            Console.WriteLine("**********Students***************");
            Console.WriteLine("List All Students \t\t press 1");
            Console.WriteLine("List Students Per Course \t\t press 2");
            Console.WriteLine("Add Student \t\t\t press 3");
            Console.WriteLine("Edit Student \t press 4");
            Console.WriteLine("Delete Student \t press 5");
            Console.WriteLine("To Go Back \t\t\t press Escape");
            Console.WriteLine("***************************************");
            Console.WriteLine("Enter Selection:");
            var userSelection = Console.ReadKey();
            while (userSelection.Key != ConsoleKey.D1 && userSelection.Key != ConsoleKey.D2 && userSelection.Key != ConsoleKey.D3 && userSelection.Key != ConsoleKey.D4 && userSelection.Key != ConsoleKey.D5 && userSelection.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Please Provide a valid option ");
                userSelection = Console.ReadKey();
            }

            switch (userSelection.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    ListAllStudents();
                    DisplayStudentsMenu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    ListAllCourses();
                    Console.WriteLine("Choose Course");
                    var selection = Convert.ToInt32(Console.ReadLine());
                    AllCourses[selection].ListStudents();
                    DisplayStudentsMenu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    AddStudent();
                    DisplayStudentsMenu();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine("****** Edit Student ********\b");
                    ListAllStudents();
                    var student = Convert.ToInt32(Console.ReadLine());
                    AllStudents[student].EditStudent();
                    DisplayStudentsMenu();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    Console.WriteLine("********* Delete Student **********");
                    ListAllStudents();
                    DeleteStudent();
                    DisplayStudentsMenu();
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    DisplayMenu();
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }
        public static void DisplayTrainersMenu()
        {
            Console.WriteLine("**********Trainers***************");
            Console.WriteLine("List All Trainers \t\t press 1");
            Console.WriteLine("List Trainers Per Course \t\t press 2");
            Console.WriteLine("Add Trainer \t\t\t press 3");
            Console.WriteLine("Edit Trainer \t press 4");
            Console.WriteLine("Delete Trainer \t press 5");
            Console.WriteLine("To Go Back \t\t\t press Escape");
            Console.WriteLine("***************************************");
            Console.WriteLine("Enter Selection:");
            var userSelection = Console.ReadKey();
            while (userSelection.Key != ConsoleKey.D1 && userSelection.Key != ConsoleKey.D2 && userSelection.Key != ConsoleKey.D3 && userSelection.Key != ConsoleKey.D4 && userSelection.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Please Provide a valid option ");
                userSelection = Console.ReadKey();
            }

            switch (userSelection.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    ListAllTrainers();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    ListAllTrainers();
                    Console.WriteLine("Choose Course");
                    var selection = Convert.ToInt32(Console.ReadLine());
                    AllCourses[selection].ListTrainers();
                    DisplayStudentsMenu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    AddTrainer();
                    DisplayTrainersMenu();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine("****** Choose Course ********\b");
                    ListAllCourses();
                    var course = Convert.ToInt32(Console.ReadLine());
                    AllCourses[course].AddTrainers();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    Console.WriteLine("********* Delete Trainer **********");
                    ListAllTrainers();
                    DeleteTrainer();
                    DisplayTrainersMenu();
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    DisplayMenu();
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }

        }
        public static void DisplayAssignmentsMenu()
        {
            Console.WriteLine("**********Assignments***************");
            Console.WriteLine("List All Assignments \t\t press 1");
            Console.WriteLine("List Assignments Per Course \t\t press 2");
            Console.WriteLine("Add Assignmemt \t\t\t press 3");
            Console.WriteLine("Edit Assignment \t press 4");
            Console.WriteLine("Delete Assignment \t press 5");
            Console.WriteLine("Add Assignmemt to Student \t\t\t press 6");
            Console.WriteLine("To Go Back \t\t\t press Escape");
            Console.WriteLine("***************************************");
            Console.WriteLine("Enter Selection:");
            var userSelection = Console.ReadKey();
            while (userSelection.Key != ConsoleKey.D1 && userSelection.Key != ConsoleKey.D2 && userSelection.Key != ConsoleKey.D3 && userSelection.Key != ConsoleKey.D4 && userSelection.Key != ConsoleKey.D5 && userSelection.Key != ConsoleKey.D6 && userSelection.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Please Provide a valid option ");
                userSelection = Console.ReadKey();
            }

            switch (userSelection.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    ListAllAssignments();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    ListAllTrainers();
                    Console.WriteLine("Choose Course");
                    var selection = Convert.ToInt32(Console.ReadLine());
                    AllCourses[selection].ListAssignments();
                    DisplayAssignmentsMenu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    AddAssignment();
                    DisplayAssignmentsMenu();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine("****** Choose Assignment ********\b");
                    ListAllAssignments();
                    var assignment = Convert.ToInt32(Console.ReadLine());
                    AllAssignments[assignment].EditAssignment();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    Console.WriteLine("********* Delete Assignment **********");
                    ListAllAssignments();
                    DeleteAssignment();
                    DisplayAssignmentsMenu();
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    Console.WriteLine("********* Add Assignment to Student**********");
                    ListAllStudents();
                    var student = Convert.ToInt32(Console.ReadLine());
                    AllStudents[student].AddAssignment();
                    DisplayAssignmentsMenu();
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    DisplayMenu();
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }

        }

        public static void AddCourse()
        {
            Console.WriteLine("******** New Course **********");
            Console.WriteLine("Enter Course Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Course Type (1:part-time, 2:full-time:");
            int type = Convert.ToInt32(Console.ReadLine());
            CourseType courseType = (CourseType)type;
            Console.WriteLine("Enter Stream:");
            string stream = Console.ReadLine();
            Console.WriteLine("Enter Start Date: (year,month,date)");
            DateTime startDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter End Date: (year,month,date)");
            DateTime endDate = Convert.ToDateTime(Console.ReadLine());
            var course = new Course(title, courseType, stream, startDate, endDate);
            AllCourses.Add(course);
            Console.Clear();
            Console.WriteLine($"Course: {title} succesfully added!");
        }

        public static void AddTrainer()
        {
            Console.WriteLine("******** New Trainer **********\b");
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Subject:");
            string subject = Console.ReadLine();
            var trainer = new Trainer(firstName, lastName, subject);
            Console.WriteLine("Choose Course:");
            ListAllCourses();
            Console.WriteLine("Enter Course Number:");
            var course = Convert.ToInt32(Console.ReadLine());
            AllCourses[course].Trainers.Add(trainer);
            AllTrainers.Add(trainer);
            Console.Clear();
            Console.WriteLine($"Trainer: {trainer.Fullname} succesfully added!");
        }

        public static void AddStudent()
        {
            Console.WriteLine("******** New Student **********");
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Date Of Birth:");
            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Tuition Fees:");
            double tuitionFees = Convert.ToDouble(Console.ReadLine());
            var student = new Student(firstName, lastName, dateOfBirth, tuitionFees);
            Console.WriteLine("Choose Course:");
            ListAllCourses();
            Console.WriteLine("Enter Course Number:");
            var course = Convert.ToInt32(Console.ReadLine());
            AllCourses[course].Students.Add(student);
            AllStudents.Add(student);
        }
        public static void AddAssignment()
        {
            Console.WriteLine("******** New Assignment **********");
            Console.WriteLine("Enter Title:");
            string title = Console.ReadLine();
            Console.WriteLine("EnterDescription:");
            string description = Console.ReadLine();
            Console.WriteLine("Enter Submission Date:");
            DateTime subDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Choose Course:");
            ListAllCourses();
            Console.WriteLine("Enter Course Number:");
            var course = Convert.ToInt32(Console.ReadLine());
            var assignment = new Assignment(title, description, subDate);
            AllCourses[course].Assignments.Add(assignment);
            AllAssignments.Add(assignment);
            Console.Clear();
            Console.WriteLine($"Assignment {assignment.Title} sucessfully added.");
        }
        public static void DeleteStudent()
        {
            Console.WriteLine("Enter the number of the student to be deleted:");
            try
            {
                var selection = Convert.ToInt32(Console.ReadLine());

                //removes it from the students list of each course
                foreach (var course in AllCourses)
                {
                    var index = course.Students.IndexOf(AllStudents[selection]);
                    Console.Clear();
                    Console.WriteLine($"Student {AllStudents[selection].Fullname} succesfully deleted");
                    course.Students.RemoveAt(index);

                }
                AllStudents.RemoveAt(selection);
                ListAllStudents();
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Selection");

            }
        }
        public static void DeleteTrainer()
        {
            Console.WriteLine("Enter the number of the trainer to be deleted:");
            try
            {
                var selection = Convert.ToInt32(Console.ReadLine());

                //removes it from the students list of each course
                foreach (var course in AllCourses)
                {
                    var index = course.Trainers.IndexOf(AllTrainers[selection]);
                    Console.Clear();
                    Console.WriteLine($"Student {AllTrainers[selection].Fullname} succesfully deleted");
                    course.Trainers.RemoveAt(index);

                }
                AllTrainers.RemoveAt(selection);
                ListAllTrainers();
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Selection");

            }
        }
        public static void DeleteAssignment()
        {
            Console.WriteLine("Enter the number of the assignment to be deleted:");
            try
            {
                var selection = Convert.ToInt32(Console.ReadLine());

                //removes it from the students list of each course
                foreach (var course in AllCourses)
                {
                    var index = course.Assignments.IndexOf(AllAssignments[selection]);
                    Console.Clear();
                    Console.WriteLine($"Student {AllAssignments[selection].Title} succesfully deleted");
                    course.Assignments.RemoveAt(index);

                }
                AllAssignments.RemoveAt(selection);
                ListAllAssignments();
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Selection");

            }
        }
    }
    
}
