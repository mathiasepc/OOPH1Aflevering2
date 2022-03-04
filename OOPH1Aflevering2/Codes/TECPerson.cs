using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering2.Codes
{
    internal class TECPerson : IComparable<TECPerson>
    {
        public SchoolingCategory UddannelsesLinje { get; set; }
        public string? FullName { get; set; }
        public int CompareTo(TECPerson? nextName)
        {
            return FullName.CompareTo(nextName.FullName);
        }
    }
}
