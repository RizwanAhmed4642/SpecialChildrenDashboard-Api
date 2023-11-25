using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.Entities
{
    public partial class ApplicationScreen
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Descrption { get; set; }
        public int Order { get; set; }
        public string CatgeoryId { get; set; }
        public bool IsOnWebPortal { get; set; }
        public bool IsOnMobile { get; set; }
        public int CustomCode { get; set; }
        public bool Status { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }

        public virtual Category Catgeory { get; set; }
    }
}
