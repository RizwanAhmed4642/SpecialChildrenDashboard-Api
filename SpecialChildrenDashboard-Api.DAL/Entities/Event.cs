using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class Event
    {
        public Event()
        {
            PatientRegistrations = new HashSet<PatientRegistration>();
        }

        public string Id { get; set; }
        public string EventCategoryId { get; set; }
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public string Venue { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string DistrictId { get; set; }
        public string HealthFacilityTypeId { get; set; }
        public string HealthFacilityId { get; set; }
        public bool IsTemp { get; set; }
        public bool Status { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool AutoGenerateTokken { get; set; }
        public bool BackDateEntry { get; set; }
        public int? EntryDay { get; set; }

        public virtual Category Category { get; set; }
        public virtual EventCategory EventCategory { get; set; }
        public virtual ICollection<PatientRegistration> PatientRegistrations { get; set; }
    }
}
