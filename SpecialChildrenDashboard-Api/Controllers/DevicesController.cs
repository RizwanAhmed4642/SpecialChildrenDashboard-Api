using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SpecialChildrenDashboard_Api.BAL.Helper;
using SpecialChildrenDashboard_Api.BAL.ViewModel;
using System.Collections.Generic;
using System;
using SpecialChildrenDashboard_Api.BAL.Interface;
using SpecialChildrenDashboard_Api.DAL.Entities;


namespace SpecialChildrenDashboard_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private readonly IDevices devicesevices;
        public DevicesController(IDevices devicesevices)
        {
            this.devicesevices = devicesevices;
        }
        [Route("GetPhysicalDevicesReport")]
        [HttpPost]
        public List<V_PhysicalDevicesReport> GetPhysicalDiseasesReport(DashboardDetailDto model)
        {
            var res = devicesevices.GetPhysicalDevicesReport(model);
            return res;
        } 
       
        //[Route("GetOphthalmologistDiseasesReport")]
        //[HttpPost]
        //public List<V_OphthalmologistDiseasesReport> GetOphthalmologistDiseasesReport(DashboardDetailDto model)
        //{
        //    var res = diseasesService.GetOphthalmologistDiseasesReport(model);
        //    return res;
        //} 
        
        //[Route("GetEntReport")]
        //[HttpPost]
        //public List<V_ENTDiseasesReport> GetEntReport(DashboardDetailDto model)
        //{
        //    var res = diseasesService.GetEntReport(model);
        //    return res;
        //}
       
    }
}
