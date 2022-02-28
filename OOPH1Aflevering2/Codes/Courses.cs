using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering2.Codes
{
    internal sealed class Courses : Schooling
    {
        public Courses(List<TECPerson> teaches, SchoolingCategory schoolingName) : base(teaches, schoolingName)
        {
        }

        public List<string> SchoolingCourses { get; set; }

        public override string GetTeacher()
        {
            throw new NotImplementedException();
        }
        public override void SetCourses(List<string> courses)
        {
            
        }
    }   
}
