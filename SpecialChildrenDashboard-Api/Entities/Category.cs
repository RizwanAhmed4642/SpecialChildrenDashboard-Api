using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.Entities
{
    public partial class Category
    {
        public Category()
        {
            ApplicationScreens = new HashSet<ApplicationScreen>();
            Events = new HashSet<Event>();
            PatientRegistrations = new HashSet<PatientRegistration>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Remarks { get; set; }
        public bool Status { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<ApplicationScreen> ApplicationScreens { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<PatientRegistration> PatientRegistrations { get; set; }
    }
}
