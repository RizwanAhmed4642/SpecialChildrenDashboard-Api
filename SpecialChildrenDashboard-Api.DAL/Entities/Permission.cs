using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class Permission
    {
        public long Id { get; set; }
        public string PermissionName { get; set; }
        public bool Status { get; set; }
    }
}
