using SpecialChildrenDashboard_Api.BAL.ViewModel;
using SpecialChildrenDashboard_Api.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.Interface
{
    public interface IDevices
    {
        public List<V_PhysicalDevicesReport> GetPhysicalDevicesReport(DashboardDetailDto model);

    }
}
