using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.ViewModel
{
    public class PhysicalDiseasesReportDto
    {
        public string TehsilId { get; set; }
        public string DistrictName { get; set; }
        public string SchoolName { get; set; }
        public int? TotalAcne { get; set; }
        public int? TotalAnyOther { get; set; }
        public int? TotalBurns { get; set; }
        public int? TotalDermatitis { get; set; }
        public int? TotalEczema { get; set; }
        public int? TotalFungalInfection { get; set; }
        public int? TotalHemangiomas { get; set; }
        public int? TotalHivesUrticaria { get; set; }
        public int? TotalImpetigo { get; set; }
        public int? TotalLiceinfestation { get; set; }
        public int? TotalPigmentationDisorderVitiligo { get; set; }
        public int? TotalPressuresoresDecubitussores { get; set; }
        public int? TotalPsoriasis { get; set; }
        public int? TotalScabies { get; set; }
        public int? TotalXerosis { get; set; }
    }
}
