using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class School
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string LocationId { get; set; }
        public string DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string TehsilId { get; set; }
        public string TehsilName { get; set; }
        public bool Status { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int ScreeningTypeId { get; set; }
    }
}
