using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpecialChildrenDashboard_Api.BAL.Interface;
using SpecialChildrenDashboard_Api.BAL.ViewModel;
using SpecialChildrenDashboard_Api.DAL.Entities;
using System;
using System.Collections.Generic;

namespace SpecialChildrenDashboard_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly ICounterDashboard dashboardService;
        public DashboardController(ICounterDashboard dashboardService)
        {
            this.dashboardService = dashboardService;
        }


        [Route("GetCounterDashboard")]
        [HttpPost]
        public DashboardCounter GetCounterDashboard(DashboardDto model)
        {
            var res = dashboardService.GetCounterDashboard(model);
            return res;
        }
        [Route("GetDashboardDetailCount")]
        [HttpPost]
        public List<DashboardDetailCount> GetDashboardDetailCount(DashboardDetailDto model)
        {
            var res = dashboardService.GetDashboardDetailCount(model);
            return res;
        }
        [Route("GetStudentList")]
        [HttpPost]
        public List<View_StudentRegistration> GetStudentList(StudentDto model)
        {
            var res = dashboardService.GetStudentList(model);

            return res;
        }

    }
}
