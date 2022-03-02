using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering2.Codes
{
    internal abstract class Schooling
    {
        public SchoolingCategory SchoolingName { get; set; }

        public CourseCategory CourseName { get; set; }
        public List<TECPerson> Teachers { get; set; }
        public List<string>? Courses { get; set; }

        public Schooling(SchoolingCategory schoolingName)
        {
            List<TECPerson> teacherName = new()
            {
                new TECPerson { FullName = "Niels Olsen", UddannelsesLinje = SchoolingCategory.Programmingcourse },
                new TECPerson { FullName = "Bo Hansen", UddannelsesLinje = SchoolingCategory.Supportcourse },
                new TECPerson { FullName = "Ole Nielsen", UddannelsesLinje = SchoolingCategory.infrastructure }
            };
            Teachers = teacherName.ToList();
        }

        public virtual void SetCourses()
        {
            List<string> courses = new();
            Courses = courses;
            foreach (var displayCourses in (Enum.GetNames(typeof(CourseCategory))))
            {
                courses.Add(displayCourses);
            }
        }

        public abstract void GetTeacher();

        //List<string> courses = new();
        //Courses = courses;
        //if (SchoolingName == SchoolingCategory.Programmingcourse)
        //{
        //    foreach (var displayCourses in (Enum.GetNames(typeof(CourseCategory))))
        //    {
        //        if (CourseName == CourseCategory.Basic_programming || CourseName == CourseCategory.Objectoriented_programming)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Green;
        //            courses.Add(displayCourses);
        //        }
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }
        //}
        //else if (SchoolingName == SchoolingCategory.Supportcourse)
        //{
        //    foreach (var displayCourses in (Enum.GetNames(typeof(CourseCategory))))
        //    {

        //        if (CourseName == CourseCategory.Web_server || CourseName == CourseCategory.Database_server)
        //            Console.ForegroundColor = ConsoleColor.Yellow;

        //        courses.Add(displayCourses);
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }
        //}
        //else
        //{
        //    foreach (var displayCourses in (Enum.GetNames(typeof(CourseCategory))))
        //    {
        //        if (CourseName == CourseCategory.WAN_ethernet || CourseName == CourseCategory.LAN_ethernet)
        //            Console.ForegroundColor = ConsoleColor.Blue;

        //        courses.Add(displayCourses);
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }
        //}



        //foreach (var displayCourses in (Enum.GetNames(typeof(CourseCategory))))
        //{

        //    if (CourseName == CourseCategory.Basic_programming || CourseName == CourseCategory.Objectoriented_programming)
        //        Console.ForegroundColor = ConsoleColor.Green;
        //    else if (CourseName == CourseCategory.Web_server || CourseName == CourseCategory.Database_server)
        //        Console.ForegroundColor = ConsoleColor.;
        //    courses.Add(displayCourses);

        //    Console.ForegroundColor = ConsoleColor.White;
        //}
    }


}


