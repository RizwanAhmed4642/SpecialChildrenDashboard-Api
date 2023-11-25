using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.Entities
{
    public partial class DiseaseCategory
    {
        public DiseaseCategory()
        {
            Diseases = new HashSet<Disease>();
        }

        public long Id { get; set; }
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

        public virtual ICollection<Disease> Diseases { get; set; }
    }
}
