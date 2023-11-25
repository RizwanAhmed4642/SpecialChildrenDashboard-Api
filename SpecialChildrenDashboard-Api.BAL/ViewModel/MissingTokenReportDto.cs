using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.ViewModel
{
    public class MissingTokenReportDto
    {
        public string DistrictName  { get; set; }
        public string SchoolName  { get; set; }
        public int TokenNo { get; set; }
        public string Name { get; set; }
        public string ClassGrade { get; set; }
        public string Regdate { get; set; }
        public string Parameter { get; set; }

    }
}
