using SpecialChildrenDashboard_Api.BAL.Service;
using SpecialChildrenDashboard_Api.BAL.ViewModel;
using SpecialChildrenDashboard_Api.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.Interface
{
    public interface ICounterDashboard
    {
        public DashboardCounter GetCounterDashboard(DashboardDto model);
        public List<DashboardDetailCount> GetDashboardDetailCount(DashboardDetailDto model);
        public List<View_StudentRegistration> GetStudentList(StudentDto model);

    }

}
