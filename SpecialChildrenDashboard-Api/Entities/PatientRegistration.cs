using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.Entities
{
    public partial class PatientRegistration
    {
        public PatientRegistration()
        {
            DentalTransactions = new HashSet<DentalTransaction>();
            DermatologistDoc4s = new HashSet<DermatologistDoc4>();
            ENTDoc3s = new HashSet<ENTDoc3>();
            Immunizations = new HashSet<Immunization>();
            OphthalmologistDoc2s = new HashSet<OphthalmologistDoc2>();
            PatientFollowUps = new HashSet<PatientFollowUp>();
            PediatricianDoc1s = new HashSet<PediatricianDoc1>();
            PhysicalParameters = new HashSet<PhysicalParameter>();
            PhysiotherapistDoc7s = new HashSet<PhysiotherapistDoc7>();
            PsychologistDoc5s = new HashSet<PsychologistDoc5>();
            Serologicals = new HashSet<Serological>();
            SpeechTherapistDoc6s = new HashSet<SpeechTherapistDoc6>();
        }

        public long Id { get; set; }
        public string EventId { get; set; }
        public string HealthFacilityId { get; set; }
        public DateTime Regdate { get; set; }
        public string CategoryId { get; set; }
        public long TokenNo { get; set; }
        public string UniqueId { get; set; }
        public long? DesignationId { get; set; }
        public string Name { get; set; }
        public string Swo { get; set; }
        public string Dob { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string NameOfInstitute { get; set; }
        public string ClassGrade { get; set; }
        public bool PrintStatus { get; set; }
        public string PrintDate { get; set; }
        public string CreatedByLocation { get; set; }
        public bool Status { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DistrictId { get; set; }
        public string TehsilId { get; set; }
        public string CategoryString { get; set; }
        public string ContactNo { get; set; }
        public string SchoolId { get; set; }
        public string BForm { get; set; }
        public int ScreeningTypeId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual Event Event { get; set; }
        public virtual ICollection<DentalTransaction> DentalTransactions { get; set; }
        public virtual ICollection<DermatologistDoc4> DermatologistDoc4s { get; set; }
        public virtual ICollection<ENTDoc3> ENTDoc3s { get; set; }
        public virtual ICollection<Immunization> Immunizations { get; set; }
        public virtual ICollection<OphthalmologistDoc2> OphthalmologistDoc2s { get; set; }
        public virtual ICollection<PatientFollowUp> PatientFollowUps { get; set; }
        public virtual ICollection<PediatricianDoc1> PediatricianDoc1s { get; set; }
        public virtual ICollection<PhysicalParameter> PhysicalParameters { get; set; }
        public virtual ICollection<PhysiotherapistDoc7> PhysiotherapistDoc7s { get; set; }
        public virtual ICollection<PsychologistDoc5> PsychologistDoc5s { get; set; }
        public virtual ICollection<Serological> Serologicals { get; set; }
        public virtual ICollection<SpeechTherapistDoc6> SpeechTherapistDoc6s { get; set; }
    }
}
