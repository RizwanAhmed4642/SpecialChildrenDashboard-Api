using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.Entities
{
    public partial class Designation
    {
        public Designation()
        {
            InverseDesignationNavigation = new HashSet<Designation>();
            PatientRegistrations = new HashSet<PatientRegistration>();
        }

        public long Id { get; set; }
        public long? CadreId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public long? DesignationId { get; set; }
        public bool Status { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }

        public virtual Cadre Cadre { get; set; }
        public virtual Designation DesignationNavigation { get; set; }
        public virtual ICollection<Designation> InverseDesignationNavigation { get; set; }
        public virtual ICollection<PatientRegistration> PatientRegistrations { get; set; }
    }
}
