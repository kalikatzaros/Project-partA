using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partA
{
    class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public double OralMark { get; set; }
        public double TotalMark { get; set; }

        public Assignment()
        {
                
        }

        public Assignment(string title, string description, DateTime subDateTime)
        {
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
        }

        public void EditAssignment()  
        {
            Console.WriteLine("******** Edit Assignment **********");
            Console.WriteLine($"Title: {Title} Edit Title:");
            string title = Console.ReadLine();
            Title = (title == string.Empty) ? Title : title;
            Console.WriteLine("EnterDescription:");
            string description = Console.ReadLine();
            Description = (description == string.Empty) ? Description : description;
            Console.WriteLine("Enter Submission Date: (year-month-day");
            try
            {
                DateTime subDate = Convert.ToDateTime(Console.ReadLine());
                SubDateTime = subDate;
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Date",e);
                SubDateTime = SubDateTime;
            }
            Console.Clear();
            Console.WriteLine($"Assignment {Title} sucessfully editted.");
        }
    }
}
