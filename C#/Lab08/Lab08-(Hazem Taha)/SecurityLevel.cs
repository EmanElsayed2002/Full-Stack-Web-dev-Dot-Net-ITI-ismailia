using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    [Flags]
    public enum SecurityLevel
    {
        Guest=1,
        Developer=2,
        Secretary=4,
        DBA=8,
        securityOfficer=0b1111,
    }

}
