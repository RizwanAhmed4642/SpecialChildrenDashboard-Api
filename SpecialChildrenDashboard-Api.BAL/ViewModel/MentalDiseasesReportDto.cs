using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.ViewModel
{
    public class MentalDiseasesReportDto
    {
        public string DistrictName { get; set; }
        public int? TotalMacrocephalous { get; set; }
        public int? TotalDownSyndrome { get; set; }
        public int? TotalHeadInjury { get; set; }
        public int? TotalNeuroDevelopmentDisorder { get; set; }
        public int? TotalEpilepsy { get; set; }
        public int? TotalStroke { get; set; }
        public int? TotalAustinSpectrumDisorder { get; set; }
        public int? TotalAttentiondeficit { get; set; }
        public int? TotalObsessiveCompulsiveDisorder { get; set; }
        public int? TotalIntellectualDevelopmentalDisability { get; set; }
        public int? TotalAnyOther { get; set; }
     
    }
}
