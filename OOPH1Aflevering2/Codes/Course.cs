using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Reflection;


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
            List<string> schoolingCourses = new();
            SchoolingCourses = schoolingCourses;
            try
            {
                var enumType = typeof(CourseCategory);
                Array values = Enum.GetValues(typeof(CourseCategory));

                foreach (var item in values)
                {
                    DisplayAttribute? courseInfo = item.GetType().GetMember(item.ToString()).First().GetCustomAttribute<DisplayAttribute>();

                    string nameInfo = courseInfo.GetName();

                    schoolingCourses.Add(nameInfo);
                }
            }
            catch (Exception ex)
            {
                schoolingCourses.Add("Basic programming");
                schoolingCourses.Add("Objectoriented programming");
                schoolingCourses.Add("Database server");
                schoolingCourses.Add("Web server");
                schoolingCourses.Add("WAN ethernet");
                schoolingCourses.Add("LAN ethernet");
            }
        }

        public override string ToString()
        {
            return $"** OOP H1 Afleveringsopgave **";
        }

        public override void GetTeacher()
        {
            List<TECPerson> displayTeachers = new();
            Teachers = displayTeachers;
            try
            {
                foreach (var displayTeacher in Teachers)
                {
                    displayTeachers.Add(displayTeacher);
                }
            }
            catch (Exception ex)
            {
                foreach (var displayTeacher in Enum.GetValues(typeof(SchoolingCategory)))
                {
                    displayTeachers.Add((TECPerson)displayTeacher);
                }
            }
        }
    }
}


