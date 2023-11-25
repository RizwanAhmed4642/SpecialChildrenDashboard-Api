using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.Entities
{
    public partial class DashboardCounter
    {
        public int? TotalPatientRegistration { get; set; }
        public int? TotalPhysicalParameters { get; set; }
        public int? TotalDental { get; set; }
        public int? TotalOphthalmologist { get; set; }
        public int? TotalSpeechTherapist { get; set; }
        public int? TotalENT { get; set; }
        public int? TotalMentalHealth { get; set; }
        public int? TodayPatientRegistration { get; set; }
        public int? TodayPhysicalParameters { get; set; }
        public int? TodayDental { get; set; }
        public int? TodayOphthalmologist { get; set; }
        public int? TodaySpeechTherapist { get; set; }
        public int? TodayENT { get; set; }
        public int? TodayMentalHealth { get; set; }
    }
}
