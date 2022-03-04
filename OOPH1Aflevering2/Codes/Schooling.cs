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
                courses.Add(displayCourses);
        }

        public abstract void GetTeacher();
    }
}


