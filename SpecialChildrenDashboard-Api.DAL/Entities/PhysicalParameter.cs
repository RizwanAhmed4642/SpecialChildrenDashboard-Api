using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class PhysicalParameter
    {
        public long Id { get; set; }
        public long PatientRegistrationId { get; set; }
        public long TokenNo { get; set; }
        public string UniqueId { get; set; }
        public string HeightInCentimeter { get; set; }
        public string Weight { get; set; }
        public string GrowthStatus { get; set; }
        public bool Status { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string Temprature { get; set; }
        public string Pulse { get; set; }
        public string Respiratory { get; set; }
        public string EpiVaccinationStatus { get; set; }
        public string MUAC { get; set; }
        public string GeneralPhysicalExamination { get; set; }
        public string PulpableLymphNodes { get; set; }
        public string ConsciousLevel { get; set; }
        public string Tone { get; set; }
        public string Power { get; set; }
        public string AbnormalGait { get; set; }
        public string Reflexes { get; set; }
        public string TreatmentAdvised { get; set; }
        public string SkullAbnormalities { get; set; }
        public string SlantingEyes { get; set; }
        public string DepressedBridgeOfNose { get; set; }
        public string Micrognathia { get; set; }
        public string PhysicalDisabilities { get; set; }
        public string WheelChair { get; set; }
        public string Crutches { get; set; }
        public string Planter { get; set; }
        public string SkinExamination { get; set; }
        public string Distribution { get; set; }
        public string ProvisionalDiagnosis { get; set; }
        public string Stunted { get; set; }
        public string Wasted { get; set; }
        public string WheelchairManual { get; set; }
        public string WheelchairElectric { get; set; }
        public string CPChair { get; set; }
        public string Walkers { get; set; }
        public string onMedication { get; set; }
        public string SideEffect { get; set; }
        public string Microcephalic { get; set; }
        public string Hydrocephalic { get; set; }
        public string Craniofacial { get; set; }
        public string Cleft { get; set; }
        public string Club { get; set; }
        public string Tetany { get; set; }
        public string Bowed { get; set; }

        public virtual PatientRegistration PatientRegistration { get; set; }
    }
}
