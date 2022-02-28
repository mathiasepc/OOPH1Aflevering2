using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering2.Codes
{

    internal class Schooling
    {
        public SchoolingCategory SchoolingName { get; set; }
        public List<TECPerson> Teachers { get; set; }
        public List<string> Courses { get; set; }

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

       
    }
}

