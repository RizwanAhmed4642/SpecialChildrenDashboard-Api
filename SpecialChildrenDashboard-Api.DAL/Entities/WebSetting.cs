using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class WebSetting
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string WebVersion { get; set; }
        public DateTime? VersionDated { get; set; }
        public string WhatIsNew { get; set; }
        public bool IsScreening { get; set; }
        public bool IsDental { get; set; }
        public bool IsClinic { get; set; }
        public bool IsMaintainenceMode { get; set; }
        public DateTime? MaintainenceModeEnded { get; set; }
        public string DefaultTheme { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public bool Status { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
