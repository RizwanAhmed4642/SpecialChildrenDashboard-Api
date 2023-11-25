using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.ViewModel
{
    public class MisingTokenCountDto
    {

        public string DistrictName { get; set; }
        public string Name { get; set; }
        public string Parameter { get; set; }
        public int? TotalCount { get; set; }
     
    }
}
