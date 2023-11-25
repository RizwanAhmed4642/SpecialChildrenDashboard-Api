using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.Entities
{
    public partial class DentalTransaction
    {
        public long Id { get; set; }
        public long PatientRegistrationId { get; set; }
        public long TokenNo { get; set; }
        public string UniqueId { get; set; }
        public string Caries { get; set; }
        public string Gingivitis { get; set; }
        public string Periodontitis { get; set; }
        public string Malocclusion { get; set; }
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
        public string TreatmentGiven { get; set; }
        public string ReferredTo { get; set; }
        public string DentalExamination { get; set; }
        public string ProcedureAdvised { get; set; }
        public int ScreeningTypeId { get; set; }
        public string DentalExaminationFinding { get; set; }

        public virtual PatientRegistration PatientRegistration { get; set; }
    }
}
