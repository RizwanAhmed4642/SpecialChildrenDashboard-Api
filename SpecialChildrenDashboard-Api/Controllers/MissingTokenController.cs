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
    public class MissingTokenController : ControllerBase
    {
        private readonly IMissingToken missingTokenService;
        public MissingTokenController(IMissingToken missingTokenService)
        {
            this.missingTokenService = missingTokenService;
        }
        [Route("GetMisingToken")]
        [HttpPost]
        public List<View_MissingTokenCount> GetMisingToken(DashboardDetailDto model)
        {
            var res = missingTokenService.GetMisingToken(model);
            return res;
        } 
        [Route("GetMixingStudentList")]
        [HttpPost]
        public List<View_StudentRegistration> GetMixingStudentList(StudentDto model)
        {
            var res = missingTokenService.GetMixingStudentList(model);
            return res;
        } 
        [Route("GetMixingDetailList")]
        [HttpPost]
        public List<MissingTokenReportDto> GetMixingDetailList(DashboardDetailDto model)
        {
            var res = missingTokenService.GetMixingTokenDetail(model);
            return res;
        }
    }
}
