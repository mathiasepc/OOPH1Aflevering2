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
            List<string> schoolinCourses = new();
            SchoolingCourses = schoolinCourses;
            try
            {
                var enumType = typeof(CourseCategory);
                Array values = Enum.GetValues(typeof(CourseCategory));

                foreach (var item in values)
                {
                    DisplayAttribute? courseInfo = item.GetType().GetMember(item.ToString()).First().GetCustomAttribute<DisplayAttribute>();

                    string nameInfo = courseInfo.GetName();

                    schoolinCourses.Add(nameInfo);
                }
            }
            catch(Exception ex)
            {
                schoolinCourses.Add("Basic programming");
                schoolinCourses.Add("Objectoriented programming");
                schoolinCourses.Add("Database server");
                schoolinCourses.Add("WAN ethernet");
                schoolinCourses.Add("LAN ethernet");
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
                    if (SchoolingName == displayTeacher.UddannelsesLinje)
                    {
                        if (displayTeacher.FullName == "Niels Olsen")
                            displayTeachers.Add(displayTeacher);

                        else if (displayTeacher.FullName == "Bo Hansen")
                            displayTeachers.Add(displayTeacher);

                        else
                            displayTeachers.Add(displayTeacher);
                    }
                    else
                        displayTeachers.Add(displayTeacher);
                }
            }
            catch (Exception ex)
            {
                foreach(var displayTeacher in Teachers)
                {
                    displayTeachers.Add(displayTeacher);
                }
            }
        }
    }
}


