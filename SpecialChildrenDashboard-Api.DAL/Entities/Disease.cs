using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class Disease
    {
        public Disease()
        {
            FollowupDiseases = new HashSet<FollowupDisease>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public long DiseaseCategoryId { get; set; }

        public virtual DiseaseCategory DiseaseCategory { get; set; }
        public virtual ICollection<FollowupDisease> FollowupDiseases { get; set; }
    }
}
