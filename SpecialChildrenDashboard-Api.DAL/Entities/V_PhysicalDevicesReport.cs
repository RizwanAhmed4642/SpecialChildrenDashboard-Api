using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class V_PhysicalDevicesReport
    {
        public string TehsilId { get; set; }
        public string DistrictName { get; set; }
        public string SchoolName { get; set; }
        public int? Total_Wheelchair_Manual { get; set; }
        public int? Total_Wheelchair_Electric { get; set; }
        public int? Total_CP_Chair { get; set; }
        public int? Total_Walkers { get; set; }
        public int? Total_Support_Stick___Crutches { get; set; }
    }
}
