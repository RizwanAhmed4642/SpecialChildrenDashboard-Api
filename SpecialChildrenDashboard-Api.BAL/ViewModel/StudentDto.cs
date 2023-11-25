using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.ViewModel
{
    public class StudentDto
    {
        public int SchoolId { get; set; }
        public string locationId { get; set; }
        public string Param { get; set; }
        public int ScreeningTypeId { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
    }
}
