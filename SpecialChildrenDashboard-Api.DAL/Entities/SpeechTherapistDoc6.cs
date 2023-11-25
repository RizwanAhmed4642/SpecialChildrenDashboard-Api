using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class SpeechTherapistDoc6
    {
        public long Id { get; set; }
        public long PatientRegistrationId { get; set; }
        public long TokenNo { get; set; }
        public string UniqueId { get; set; }
        public string Stutter { get; set; }
        public string VocalCordsStatus { get; set; }
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
        public string ChildUserWords { get; set; }
        public string HaveCommunicateDevice { get; set; }
        public string ChildRespond { get; set; }
        public string RecievingSlt { get; set; }
        public string AcquireSlm { get; set; }
        public string TreatmentGiven { get; set; }
        public string ReferredTo { get; set; }
        public string BehaviorHistory { get; set; }
        public string SensoryIssuesFineMotorSkills { get; set; }
        public string SensoryIssuesGrossMotorSkills { get; set; }
        public string OralMotorExamination { get; set; }
        public string SpeechMilestones { get; set; }
        public string ProvisionalDiagnosis { get; set; }
        public string ResonanceDisorders { get; set; }
        public string InterventionsRequired { get; set; }
        public string FamilyHistryDisability { get; set; }
        public string ConsanguineousMarriage { get; set; }
        public string DevelopmentMileStone { get; set; }
        public int ScreeningTypeId { get; set; }

        public virtual PatientRegistration PatientRegistration { get; set; }
    }
}
