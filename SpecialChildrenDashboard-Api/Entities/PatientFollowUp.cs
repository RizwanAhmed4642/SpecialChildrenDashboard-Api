using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.Entities
{
    public partial class PatientFollowUp
    {
        public PatientFollowUp()
        {
            FollowupDiseases = new HashSet<FollowupDisease>();
        }

        public long Id { get; set; }
        public long PatientRegistrationId { get; set; }
        public bool Status { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public long TokenNo { get; set; }
        public string NameOfDoctor { get; set; }
        public string MedicineProvided { get; set; }
        public string ReferralRequired { get; set; }
        public DateTime? CheckupDate { get; set; }
        public string CheckupDone { get; set; }
        public string Tests { get; set; }
        public string ReferredFacilityId { get; set; }
        public string CheckupFacilityId { get; set; }
        public string Extra { get; set; }
        public string ReferredReason { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string CheckupDoctorName { get; set; }
        public string CheckupRemarks { get; set; }

        public virtual PatientRegistration PatientRegistration { get; set; }
        public virtual ICollection<FollowupDisease> FollowupDiseases { get; set; }
    }
}
