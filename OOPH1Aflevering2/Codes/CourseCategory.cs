using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OOPH1_Aflevering.Codes
{
    public enum CourseCategory
    {
        //[] = attribute programmering
        [Display(Name = "Basic programming")] Basic_programming,
        [Display(Name = "Objectoriented programming")] Objectoriented_programming,
        [Display(Name = "Web server")] Web_server,
        [Display(Name = "Database server")] Database_server,
        [Display(Name = "WAN ethernet")] WAN_ethernet,
        [Display(Name = "LAN ethernet")] LAN_ethernet
    }
}
