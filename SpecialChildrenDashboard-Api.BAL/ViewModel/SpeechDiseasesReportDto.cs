using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.ViewModel
{
    public class SpeechDiseasesReportDto
    {
        public string DistrictName { get; set; }
 
        public int? TotalSpeechandLanguageDisorders { get; set; }
        public int? TotalStammering { get; set; }
        public int? TotalArticulationDisorder { get; set; }
        public int? TotalHearingimpairment { get; set; }
        public int? TotalSelectiveMutism { get; set; }
        public int? TotalDownsyndrome { get; set; }
        public int? TotalHoarseness { get; set; }
        public int? TotalDysarthia { get; set; }
        public int? TotalDysphagia { get; set; }
        public int? TotalVocalcordparalysis { get; set; }
        public int? TotalPuberphonia { get; set; }
        public int? TotalStuttering { get; set; }
        public int? TotalProtrudingTongue { get; set; }

    }
}
