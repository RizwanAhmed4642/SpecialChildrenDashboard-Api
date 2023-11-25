using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class View_MissingTokenCount
    {
        public string TehsilId { get; set; }
        public long SchoolId { get; set; }
        public string DistrictName { get; set; }
        public string SchoolName { get; set; }
        public int? TotalPhysicalParameter { get; set; }
        public int? TotalDentalTransactions { get; set; }
        public int? TotalOphthalmologist { get; set; }
        public int? TotalSpeechTherapist { get; set; }
        public int? TotalENT { get; set; }
        public int? TotalPsychologist { get; set; }
    }
}
