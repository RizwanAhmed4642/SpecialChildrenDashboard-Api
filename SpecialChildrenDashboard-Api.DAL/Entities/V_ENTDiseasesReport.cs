using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class V_ENTDiseasesReport
    {
        public string DistrictName { get; set; }
        public string SchoolName { get; set; }
        public string TehsilId { get; set; }
        public int? TotalOtalgia { get; set; }
        public int? TotalEarDischarge { get; set; }
        public int? TotalMicrotia { get; set; }
        public int? TotalImpactedCerumen { get; set; }
        public int? TotalAOM { get; set; }
        public int? TotalCSOM { get; set; }
    }
}
