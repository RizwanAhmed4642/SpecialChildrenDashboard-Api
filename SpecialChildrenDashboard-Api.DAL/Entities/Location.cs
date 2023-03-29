using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class Location
    {
        public string PKCODE { get; set; }
        public string FKCODE { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
        public string LVL { get; set; }
        public long? LNTH { get; set; }
    }
}
