﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.ViewModel
{
    public class DashboardDto
    {
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public int ScreeningTypeId { get; set; }
        public string Location { get; set; }
    }
}
