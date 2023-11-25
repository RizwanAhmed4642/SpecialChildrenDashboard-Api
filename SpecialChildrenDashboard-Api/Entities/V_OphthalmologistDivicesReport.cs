using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.Entities
{
    public partial class V_OphthalmologistDivicesReport
    {
        public string DistrictName { get; set; }
        public string SchoolName { get; set; }
        public string TehsilId { get; set; }
        public int? Total_Spectacles_Adviced { get; set; }
        public int? Total_Monocular { get; set; }
        public int? Total_Binocular { get; set; }
        public int? Total_Stand_Magnifiers { get; set; }
        public int? Total_Table_Lamps { get; set; }
        public int? Total_Digital_CCTV { get; set; }
        public int? Total_Reading_stand { get; set; }
        public int? Total_Typoscope { get; set; }
        public int? Total_Filters_Glasses_for_Low_Vision { get; set; }
        public int? Total_Magnifying_Glasses { get; set; }
        public int? Total_Whitecane_for_Blind { get; set; }
        public int? Total_Tablets { get; set; }
        public int? Total_Envision___Smart_Readable_Glasses { get; set; }
    }
}
