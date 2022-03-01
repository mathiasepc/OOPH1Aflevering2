using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering2.Codes
{
    internal sealed class Course : Schooling
    {
        public List<string> SchoolingCourses { get; set; }
        public Course(SchoolingCategory schoolingName) : base(schoolingName)
        {
            SetCourses();
        }
        public override void SetCourses()
        {
            base.SetCourses();
            if (SchoolingName == SchoolingCategory.Programmingcourse)
            {
                List<string> schoolingCourses = Courses.Where(a => a.Contains("programming")).ToList();
                SchoolingCourses = schoolingCourses;
            }
            else if (SchoolingName == SchoolingCategory.Supportcourse)
            {
                List<string> schoolingCourses = Courses.Where(a => a.Contains("server")).ToList();
                SchoolingCourses = schoolingCourses;
            }
            else
            {
                List<string> schoolingCourses = Courses.Where(a => a.Contains("ethernet")).ToList();
                SchoolingCourses = schoolingCourses;
            }
        }

        public override void GetTeacher()
        {
            foreach (var displayTeachers in Teachers)
            {
                if (SchoolingName == displayTeachers.UddannelsesLinje)
                {
                    if (displayTeachers.FullName == "Niels Olsen")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{displayTeachers.FullName}");
                    }
                    else if (displayTeachers.FullName == "Bo Hansen")
                    {
                        Console.ForegroundColor= ConsoleColor.Yellow;
                        Console.WriteLine($"{displayTeachers.FullName}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{displayTeachers.FullName}");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{displayTeachers.FullName}");
                }
            }
        }
    }
}
