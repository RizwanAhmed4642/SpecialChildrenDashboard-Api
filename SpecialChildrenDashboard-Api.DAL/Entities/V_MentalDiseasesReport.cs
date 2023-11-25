using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class V_MentalDiseasesReport
    {
        public string DistrictName { get; set; }
        public string SchoolName { get; set; }
        public string TehsilId { get; set; }
        public int? TotalMacrocephalous { get; set; }
        public int? TotalDownSyndrome { get; set; }
        public int? TotalHeadInjury { get; set; }
        public int? TotalNeuroDevelopmentDisorder { get; set; }
        public int? TotalIntellectualDeficit { get; set; }
        public int? TotalIChildhoodDepression { get; set; }
        public int? TotalChildrenAnxiety { get; set; }
        public int? TotalSeparationAnxiety { get; set; }
        public int? TotalAdjustmentDisorder { get; set; }
        public int? TotalStress { get; set; }
    }
}
