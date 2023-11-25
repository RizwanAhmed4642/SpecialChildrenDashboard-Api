using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.Entities
{
    public partial class MissingTokenCounter
    {
        public string TehsilId { get; set; }
        public long SchoolId { get; set; }
        public string DistrictName { get; set; }
        public string SchoolName { get; set; }
        public int? TotalCount { get; set; }
        public string Parameter { get; set; }
    }
}
