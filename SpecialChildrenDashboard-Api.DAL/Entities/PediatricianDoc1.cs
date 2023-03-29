using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class PediatricianDoc1
    {
        public long Id { get; set; }
        public long PatientRegistrationId { get; set; }
        public long TokenNo { get; set; }
        public string UniqueId { get; set; }
        public string Anemia { get; set; }
        public string Jaundice { get; set; }
        public string Cyanosis { get; set; }
        public string GCS { get; set; }
        public string MotorFunctions { get; set; }
        public string SensoryFunctions { get; set; }
        public string DewormingRequired { get; set; }
        public string MultivitaminRequired { get; set; }
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
        public string RespiratorySystem { get; set; }
        public string Abdomen { get; set; }
        public string IronSupplementRequired { get; set; }
        public string TreatmentGiven { get; set; }
        public string ReferredTo { get; set; }

        public virtual PatientRegistration PatientRegistration { get; set; }
    }
}
