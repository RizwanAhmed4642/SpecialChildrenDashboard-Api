using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.Entities
{
    public partial class V_OphthalmologistDiseasesReport
    {
        public string DistrictName { get; set; }
        public string SchoolName { get; set; }
        public string TehsilId { get; set; }
        public int? TotalRetinitisPigmentosa { get; set; }
        public int? TotalGlaucoma { get; set; }
        public int? TotalChalazion { get; set; }
        public int? TotalSquint { get; set; }
        public int? TotalVernalKeratoConjunctivitis { get; set; }
        public int? TotalBlepharitis { get; set; }
        public int? TotalConjunctivitis { get; set; }
        public int? TotalAbnormalFundalGlow { get; set; }
    }
}
