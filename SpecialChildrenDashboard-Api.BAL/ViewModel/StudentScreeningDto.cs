using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.ViewModel
{
    public class StudentScreeningDto
    {
        public string TehsilId { get; set; }
        public long SchoolId { get; set; }
        public string DistrictName { get; set; }
        public string SchoolName { get; set; }
        public long? TokenNo { get; set; }
        public string Name { get; set; }
        public string Swo { get; set; }
        public string ClassGrade { get; set; }
        public string BForm { get; set; }
        public string Parameter { get; set; }
    }
}
