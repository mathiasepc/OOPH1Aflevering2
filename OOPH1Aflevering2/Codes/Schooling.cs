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
        public List<TECPerson> Teachers { get; set; }
        public List<string> Courses { get; set; }

        public Schooling(List<TECPerson> teaches, SchoolingCategory schoolingName)
        {
            Teachers = teaches;
            SchoolingName = schoolingName;

            List<TECPerson> teachers = new()
            {
                new TECPerson { FullName = "Niels Olsen", UddannelsesLinje = (CourseCategory)SchoolingCategory.Programmeringslinje },
                new TECPerson { FullName = "Bo Hansen", UddannelsesLinje = (CourseCategory)SchoolingCategory.Supportlinje },
                new TECPerson { FullName = "Ole Nielsen", UddannelsesLinje = (CourseCategory)SchoolingCategory.Infrastrukturlinje }
            };
        }

        public virtual void SetCourses(List<string>courses)
        {
            List<string> course= new();
            Courses = courses;
            foreach (string displayCourses in (Enum.GetNames(typeof(CourseCategory))))
            {
                Console.WriteLine(displayCourses.ToString());
                courses.Add(displayCourses);
            }
        }

        public abstract string GetTeacher();
    }
}

