using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class OphthalmologistDoc2
    {
        public long Id { get; set; }
        public long PatientRegistrationId { get; set; }
        public long TokenNo { get; set; }
        public string UniqueId { get; set; }
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
        public string LeftVisualActivityStatus { get; set; }
        public string RightVisualActivityStatus { get; set; }
        public string LeftSquint { get; set; }
        public string RightSquint { get; set; }
        public string RightOculurMedia { get; set; }
        public string LeftOculurMedia { get; set; }
        public string RightConjunctiva { get; set; }
        public string LeftConjunctiva { get; set; }
        public string TreatmentGiven { get; set; }
        public string ReferredTo { get; set; }
        public string ColorVisionImpaired { get; set; }
        public string RightEyeFarVision { get; set; }
        public string LeftEyeFarVision { get; set; }
        public string Category { get; set; }
        public string FeedbackVisualAcuity { get; set; }
        public string RightEyeNearVision { get; set; }
        public string LeftEyeNearVision { get; set; }
        public string FarLeftSphericalNo { get; set; }
        public string FarLeftCylindricalAxis { get; set; }
        public string FarLeftCylindricalNo { get; set; }
        public string FarLeftVisualAcuityNo { get; set; }
        public string FarRightSphericalNo { get; set; }
        public string FarRightCylindricalAxis { get; set; }
        public string FarRightCylindricalNo { get; set; }
        public string FarRightVisualAcuityNo { get; set; }
        public string NearLeftSphericalNo { get; set; }
        public string NearLeftCylindricalAxis { get; set; }
        public string NearLeftCylindricalNo { get; set; }
        public string NearLeftVisualAcuityNo { get; set; }
        public string NearRightSphericalNo { get; set; }
        public string NearRightCylindricalAxis { get; set; }
        public string NearRightCylindricalNo { get; set; }
        public string NearRightVisualAcuityNo { get; set; }
        public string ProvisionalDiagnosis { get; set; }
        public string TreatmentAdvised { get; set; }
        public string SpectaclesAdvised { get; set; }
        public string RefractiveError { get; set; }
        public string Monocular { get; set; }
        public string Binocular { get; set; }
        public string StandMagnifiers { get; set; }
        public string TableLamps { get; set; }
        public string DigitalCCTV { get; set; }
        public string Readingstand { get; set; }
        public string Typoscope { get; set; }
        public string Filtersglasses { get; set; }
        public string Magnifying { get; set; }
        public string Whitecaneforblind { get; set; }
        public string Tablets { get; set; }
        public string Envision { get; set; }
        public string SpectaclesAdviced { get; set; }
        public int ScreeningTypeId { get; set; }

        public virtual PatientRegistration PatientRegistration { get; set; }
    }
}
