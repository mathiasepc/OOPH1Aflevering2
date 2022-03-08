using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPH1Aflevering2.Codes
{
    internal sealed class Course : Schooling
    {
        #region Properties
        public List<string> SchoolingCourses { get; set; }
        #endregion

        #region Constructor
        public Course(SchoolingCategory schoolingName) : base(schoolingName)
        {
            SchoolingCourses = new List<string>();

            base.SetCourses(schoolingName);
            SetCourses(schoolingName);
        }
        #endregion

        #region Methods
        public override void SetCourses(SchoolingCategory schoolingName)
        {
            SchoolingCourses = new List<string>();

            switch (base.SchoolingName)
            {
                case SchoolingCategory.Programmingcourse:
                    SchoolingCourses = base.Courses.Where(a => a.ToLower().Contains("programming")).ToList();
                    break;
                case SchoolingCategory.Supportcourse:
                    SchoolingCourses = base.Courses.Where(a => a.ToLower().Contains("server")).ToList();
                    break;
                case SchoolingCategory.infrastructure:
                    SchoolingCourses = base.Courses.Where(a => a.ToLower().Contains("ethernet")).ToList();
                    break;
            }
        }

        public override string GetTeacher()
        {
            string fullName = null;

            if(Teachers != null)
            {
                TECPerson teacher = Teachers.FirstOrDefault(a => a.UddannelsesLinje == SchoolingName);
                if(teacher != null)
                {
                    fullName = teacher.FullName;
                }
            }
            return fullName;
        }


        public override string ToString()
        {
            return $"** OOP H1 Afleveringsopgave **";
        }
        #endregion
    }
}


