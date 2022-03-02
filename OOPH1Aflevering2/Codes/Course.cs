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
            try
            {
                List<TECPerson> displayTeachers = new();
                Teachers = displayTeachers;

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
                Console.WriteLine("Noget gik galt");
            }
        }

    }
}

