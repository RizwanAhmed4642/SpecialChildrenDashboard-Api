using SpecialChildrenDashboard_Api.BAL.ViewModel;
using SpecialChildrenDashboard_Api.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.Interface
{
    public interface IMissingToken
    {
        public List<View_MissingTokenCount> GetMisingToken(DashboardDetailDto model);
        public List<View_StudentRegistration> GetMixingStudentList(StudentDto model);
        public List<MissingTokenReportDto> GetMixingTokenDetail(DashboardDetailDto model);
    }
}
