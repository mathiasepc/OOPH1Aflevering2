using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1_Aflevering.Codes
{
    internal abstract class Schooling
    {
        #region Properties

        public SchoolingCategory SchoolingName { get; set; }
        public List<TECPerson>? Teachers { get; set; }
        public List<string> Courses { get; set; }

        #endregion

        #region Constructor

        public Schooling(SchoolingCategory schoolingName)
        {
            SchoolingName = schoolingName;

            Teachers = new List<TECPerson>()
            {
                new TECPerson() { UddannelsesLinje = SchoolingCategory.Programmingcourse, FullName = "Niels Olesen" },
                new TECPerson() { UddannelsesLinje = SchoolingCategory.Supportcourse, FullName = "Bo Hansen" },
                new TECPerson() { UddannelsesLinje = SchoolingCategory.infrastructure, FullName = "Ole Nielsen" }
            };

            Courses = new List<string>();
        }

        #endregion

        #region Methods

        public virtual void SetCourses()
        {
            Courses = new List<string>();
            Array values = Enum.GetValues(typeof(CourseCategory));

            foreach (CourseCategory item in values)
            {
                MemberInfo[] memberInfo = item.GetType().GetMember(item.ToString());
                DisplayAttribute? displayAttribute = memberInfo.First().GetCustomAttribute<DisplayAttribute>();
                if (displayAttribute != null)
                {
                    string? displayName = displayAttribute.GetName();
                    if (displayName != null)
                        Courses.Add(displayName);
                }
            }
        }

        public abstract string? GetTeacher();

        #endregion
    }
}


