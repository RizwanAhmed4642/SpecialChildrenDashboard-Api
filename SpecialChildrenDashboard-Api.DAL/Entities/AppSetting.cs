using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class AppSetting
    {
        public long Id { get; set; }
        public string AppTitle { get; set; }
        public string AppVersion { get; set; }
        public DateTime VersionDate { get; set; }
        public bool MaintainenceMode { get; set; }
        public DateTime? MaintainenceModeDuration { get; set; }
        public bool IsTempEvent { get; set; }
        public bool EnableScrrening { get; set; }
        public bool EnableDentalOn { get; set; }
        public bool EnableClinic { get; set; }
        public string WebUrl { get; set; }
        public string ApiUrl { get; set; }
        public string ApiUrlAlternative { get; set; }
        public string ApiUrlAlternativeAgain { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string SmsOffNet { get; set; }
        public string SmsOnNet { get; set; }
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
