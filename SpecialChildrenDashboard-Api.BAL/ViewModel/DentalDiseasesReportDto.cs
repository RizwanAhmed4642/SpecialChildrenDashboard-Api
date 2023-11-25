using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.ViewModel
{
    public class DentalDiseasesReportDto
    {
        public string TehsilId { get; set; }
        public string DistrictName { get; set; }
        public string SchoolName { get; set; }
        public int? TotalJawDeformity { get; set; }
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
        public int? TotalAnyGrowth { get; set; }
        public int? TotalAttrition { get; set; }
        public int? TotalErosion { get; set; }
        public int? TotalAbrasion { get; set; }
        public int? TotalTongueTie { get; set; }
        public int? TotalMacroglossia { get; set; }
    }
}
