using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//bruger using reflection og componentModel
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace OOPH1Aflevering2.Codes
{
    internal abstract class Schooling
    {
        #region Properties
        public SchoolingCategory SchoolingName { get; set; }
        public List<TECPerson> Teachers { get; set; }
        public List<string>? Courses { get; set; }
        #endregion

        #region Constructor
        public Schooling(SchoolingCategory schoolingName)
        {
            
            //tilføjer lærer til mit array
            Teachers = new List<TECPerson>()
            {
                new TECPerson { FullName = "Niels Olsen", UddannelsesLinje = SchoolingCategory.Programmingcourse },
                new TECPerson { FullName = "Bo Hansen", UddannelsesLinje = SchoolingCategory.Supportcourse },
                new TECPerson { FullName = "Ole Nielsen", UddannelsesLinje = SchoolingCategory.infrastructure }
            };
            Courses = new List<string>();
        }
        #endregion

        #region Methods
        public virtual void SetCourses(SchoolingCategory schoolingName)
        {
            //opretter min liste
            Courses = new List<string>();
            //henter mine CourseCategory værdier 
            Array values = Enum.GetValues(typeof(CourseCategory));

            //læser mine værider i values i item
            foreach (CourseCategory item in values)
            {
                //bruger using reflection til at få adgang og omskrive data til string og putte i et array
                MemberInfo[] memberInfo = item.GetType().GetMember(item.ToString());
                //bruger using Component til at localisere mine string af type og members  
                DisplayAttribute displayAttribute = memberInfo.First().GetCustomAttribute<DisplayAttribute>();
                if (displayAttribute != null)
                {
                    string? displayName = displayAttribute.GetName();
                    if (displayName != null)
                    {
                        //tilføjer til min liste
                        Courses.Add(displayName);
                    }
                }
            }
        }

        public abstract void GetTeacher();

        #endregion
    }
}


