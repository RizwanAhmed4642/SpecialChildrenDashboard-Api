using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class PsychologistDoc5
    {
        public long Id { get; set; }
        public long PatientRegistrationId { get; set; }
        public long TokenNo { get; set; }
        public string UniqueId { get; set; }
        public string Anxiety { get; set; }
        public string Depression { get; set; }
        public string MSE { get; set; }
        public bool? PrintStatus { get; set; }
        public DateTime? PrintDate { get; set; }
        public bool Status { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string PsychologistDistance { get; set; }
        public string PsychologistDistanceValue { get; set; }
        public string Remarks { get; set; }
        public string TreatmentGiven { get; set; }
        public string ReferredTo { get; set; }
        public string PsychologicalAssessment { get; set; }
        public string ProvisionalDiagnosis { get; set; }
        public string InterventionsRequired { get; set; }
        public int ScreeningTypeId { get; set; }

        public virtual PatientRegistration PatientRegistration { get; set; }
    }
}
