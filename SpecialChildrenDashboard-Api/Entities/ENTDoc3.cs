using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.Entities
{
    public partial class ENTDoc3
    {
        public long Id { get; set; }
        public long PatientRegistrationId { get; set; }
        public long TokenNo { get; set; }
        public string UniqueId { get; set; }
        public string Nose { get; set; }
        public string Throat { get; set; }
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
        public string LeftEar { get; set; }
        public string RightEar { get; set; }
        public string Other { get; set; }
        public string EntHistory { get; set; }
        public string AudioMetryDone { get; set; }
        public string HearingAidUser { get; set; }
        public string Remarks { get; set; }
        public string TreatmentGiven { get; set; }
        public string ReferredTo { get; set; }
        public string HearingAssessment { get; set; }
        public string TuningForkTestRinne { get; set; }
        public string TuningForkTestWeber { get; set; }
        public string RightHLDegree { get; set; }
        public string LeftHLDegree { get; set; }
        public string RightHLType { get; set; }
        public string LeftHLType { get; set; }
        public string PureToneRemarks { get; set; }
        public string AssistiveListeningDevice { get; set; }
        public string Medication { get; set; }
        public string tympanometryValue { get; set; }
        public int ScreeningTypeId { get; set; }

        public virtual PatientRegistration PatientRegistration { get; set; }
    }
}
