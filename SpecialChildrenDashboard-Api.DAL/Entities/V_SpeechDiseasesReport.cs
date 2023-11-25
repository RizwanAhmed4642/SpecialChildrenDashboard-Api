using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class V_SpeechDiseasesReport
    {
        public string DistrictName { get; set; }
        public string SchoolName { get; set; }
        public string TehsilId { get; set; }
        public int? TotalSpeechandLanguageDisorders { get; set; }
        public int? TotalStammering { get; set; }
        public int? TotalArticulationDisorder { get; set; }
        public int? TotalHearingimpairment { get; set; }
        public int? TotalSelectiveMutism { get; set; }
        public int? TotalDownsyndrome { get; set; }
        public int? TotalHoarseness { get; set; }
    }
}
