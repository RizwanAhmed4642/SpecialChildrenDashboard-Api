using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.Entities
{
    public partial class V_DentalDiseasesReport
    {
        public string TehsilId { get; set; }
        public string DistrictName { get; set; }
        public string SchoolName { get; set; }
        public int? TotalJawDeformity { get; set; }
        public int? TotalCaries { get; set; }
        public int? TotalToothache { get; set; }
        public int? TotalGingivitis { get; set; }
        public int? TotalPeriodontitis { get; set; }
        public int? TotalMissingTeeth { get; set; }
        public int? TotalFilledTeeth { get; set; }
        public int? TotalDentalTrauma { get; set; }
        public int? TotalTMJDisorder { get; set; }
        public int? TotalCleftLipPalate { get; set; }
        public int? TotalRetainedDeciduousTeeth { get; set; }
        public int? TotalFluorosis { get; set; }
        public int? TotalStains { get; set; }
        public int? TotalOralUlcer { get; set; }
        public int? TotalCrowding { get; set; }
    }
}
