using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class V_PhysicalDiseasesReport
    {
        public string TehsilId { get; set; }
        public string DistrictName { get; set; }
        public string SchoolName { get; set; }
        public int? TotalDermatitis { get; set; }
        public int? TotalEczema { get; set; }
        public int? TotalFungalInfection { get; set; }
        public int? TotalImpetigo { get; set; }
        public int? TotalScabies { get; set; }
    }
}
