using System;
using System.Collections.Generic;

namespace NorthwindManagerDb
{
    public partial class EmployeeTerritory
    {
        public long EmployeeId { get; set; }
        public string TerritoryId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Territory Territory { get; set; }
    }
}
