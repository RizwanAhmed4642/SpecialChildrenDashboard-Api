using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.ViewModel
{
    public class ENTDiseasesReportDto
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
        public int? TotalAuralAtresia { get; set; }
        public int? TotalTinnitus { get; set; }
        public int? TotalForeignbody { get; set; }
        public int? TotalPerforatedTympanicMembrane { get; set; }
        public int? TotalOMwitheffusion { get; set; }
        public int? TotalOtomycosis { get; set; }
        public int? TotalHearingloss { get; set; }
    }
}
