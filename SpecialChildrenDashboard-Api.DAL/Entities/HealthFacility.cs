using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class HealthFacility
    {
        public int Program_Id { get; set; }
        public string ProgramName { get; set; }
        public int Project_Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectSName { get; set; }
        public int HealthFacility_Id { get; set; }
        public bool? IsActive { get; set; }
        public string PkCode { get; set; }
        public string FkGeolvl { get; set; }
        public string Code { get; set; }
        public int Id { get; set; }
        public string HFMISCode { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public int HFAC { get; set; }
        public string DivisionCode { get; set; }
        public string DivisionName { get; set; }
        public string DistrictCode { get; set; }
        public string DistrictName { get; set; }
        public string TehsilCode { get; set; }
        public string TehsilName { get; set; }
        public string CategoryCode { get; set; }
        public string HFCategoryName { get; set; }
        public string HFTypeCode { get; set; }
        public string HFTypeName { get; set; }
        public long? Entity_Lifecycle_Id { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public double? CoveredArea { get; set; }
        public double? UnCoveredArea { get; set; }
        public double? ResidentialArea { get; set; }
        public double? NonResidentialArea { get; set; }
        public string NA { get; set; }
        public string PP { get; set; }
        public string Mauza { get; set; }
        public string UcName { get; set; }
        public string UcNo { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public DateTime? Created_Date { get; set; }
        public string Created_By { get; set; }
        public string Last_Modified_By { get; set; }
        public string Users_Id { get; set; }
        public string HfmisOldCode { get; set; }
    }
}
