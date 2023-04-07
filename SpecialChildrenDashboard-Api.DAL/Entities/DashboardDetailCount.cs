using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class DashboardDetailCount
    {
        public string DistrictName { get; set; }
        public string Name { get; set; }
        public string TehsilId { get; set; }
        public long SchoolId { get; set; }
        public int? TotalScreen { get; set; }
        public int? TotalDentalTransactions { get; set; }
        public int? TotalOphthalmologist { get; set; }
        public int? TotalPhysicalParameter { get; set; }
        public int? TotalSpeechTherapist { get; set; }
        public int? TotalENT { get; set; }
        public int? TotalPsychologist { get; set; }
    }
}
