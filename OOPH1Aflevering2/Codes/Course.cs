using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1_Aflevering.Codes
{
    internal class Course : Schooling
    {
        #region Properties

        public List<string> SchoolingCourses { get; set; }

        #endregion

        #region Constructor

        public Course(SchoolingCategory schoolingName) : base(schoolingName)
        {
            SchoolingCourses = new List<string>();

            base.SetCourses();
            SetCourses();
        }

        #endregion

        #region methods

        /// <summary>
        /// Der er 3 muligheder at løse denne metode på:
        /// 1. Iterere gennem CourseCategory enum og indsæt matchede værdier i SchoolingCourses list.
        /// foreach (CourseCategory item in Enum.GetValues(typeof(CourseCategory)))
        /// {
        ///     DisplayAttribute? displayAttribute = item.GetType().GetMember(item.ToString()).First().GetCustomAttribute<DisplayAttribute>();
        ///     if(displayAttribute != null)
        ///     {
        ///         string? displayName = displayAttribute.GetName();                        
        ///         if (displayName != null && displayName.ToLower().Contains("programmering"))
        ///             SchoolingCourses.Add(displayName);
        ///     }
        /// }
        /// 
        /// 2. Iterere gennem base.Courses list og indsæt matchede værdier i SchoolingCourses list.'
        /// foreach (string item in base.Courses)
        /// {
        ///     if (item.ToLower().Contains("programmering"))
        ///         SchoolingCourses.Add(displayName);
        /// }
        /// 
        /// 3. DENNE MULIGHED ER BRUGT I METODEN
        /// hvor man med LINQ query søg i base.Courses for matchede værdi hvor LINQ skal returnere resultatet som ToList. 
        /// ToList resultatet sættes lig med SchoolingCourses list.
        /// </summary>
        public override void SetCourses()
        {
            SchoolingCourses = new List<string>();

            // BEMÆRK, AT JEG IKKE HENTER ENUM FRA CourseCategory klasse længer, men fra parent
            // klasse List<string> Courses, fordi jeg i parent implementation har lagt enumerne over
            // parent listen: List<string> Courses (og lagt i listen i det format som viser mellemrum mellem ordene).
            switch (base.SchoolingName)
            {
                case SchoolingCategory.Programmingcourse:
                    SchoolingCourses = base.Courses.Where(a => a.ToLower().Contains("programmering")).ToList();
                    break;
                case SchoolingCategory.Supportcourse:
                    SchoolingCourses = base.Courses.Where(a => a.ToLower().Contains("server")).ToList();
                    break;
                case SchoolingCategory.infrastructure:
                    SchoolingCourses = base.Courses.Where(a => a.ToLower().Contains("netværk")).ToList();
                    break;
            }
        }

        public override string? GetTeacher()
        {
            string? fullName = null;

            if (Teachers != null)
            {
                TECPerson? teacher = Teachers.FirstOrDefault(a => a.UddannelsesLinje == SchoolingName);
                if (teacher != null)
                    fullName = teacher.FullName;
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