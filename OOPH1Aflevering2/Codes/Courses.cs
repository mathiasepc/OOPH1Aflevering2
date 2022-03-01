using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering2.Codes
{
    internal sealed class Courses : Schooling
    {
        public List<string> SchoolingCourses { get; set; }
        public Courses(SchoolingCategory schoolingName) : base(schoolingName)
        {
            SchoolingName = schoolingName;
        }
        public override void SetCourses()
        {
            base.SetCourses();
            if (SchoolingName == SchoolingCategory.Programmeringslinje)
            {
                List<string> schoolingCourses = Courses.Where(a => a.Contains("programmering")).ToList();
                SchoolingCourses = schoolingCourses;
            }
            else if (SchoolingName == SchoolingCategory.Supportlinje)
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

        }

    }
}
