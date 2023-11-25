using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class View_StudentRegistration
    {
        public long PatientRegistrationId { get; set; }
        public long TokenNo { get; set; }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public string Swo { get; set; }
        public string Dob { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string NameOfInstitute { get; set; }
        public string ClassGrade { get; set; }
        public string CreatedByLocation { get; set; }
        public bool? IsDeleted { get; set; }
        public string CategoryString { get; set; }
        public string ContactNo { get; set; }
        public string SchoolId { get; set; }
        public string BForm { get; set; }
        public DateTime Regdate { get; set; }
        public string DistrictName { get; set; }
    }
}
