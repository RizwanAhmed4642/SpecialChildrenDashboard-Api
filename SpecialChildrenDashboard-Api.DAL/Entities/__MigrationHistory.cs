﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SpecialChildrenDashboard_Api.DAL.Entities
{
    public partial class __MigrationHistory
    {
        public string MigrationId { get; set; }
        public string ContextKey { get; set; }
        public byte[] Model { get; set; }
        public string ProductVersion { get; set; }
    }
}
