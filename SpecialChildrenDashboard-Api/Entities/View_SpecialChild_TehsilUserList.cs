using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.Entities
{
    public partial class View_SpecialChild_TehsilUserList
    {
        public string District { get; set; }
        public string Tehsil { get; set; }
        public string UserName { get; set; }
        public string RawPassword { get; set; }
    }
}
