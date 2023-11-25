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
    public class DiseasesController : ControllerBase
    {
        private readonly IDiseases diseasesService;
        public DiseasesController(IDiseases diseasesService)
        {
            this.diseasesService = diseasesService;
        }
        [Route("GetPhysicalDiseasesReport")]
        [HttpPost]
        public List<PhysicalDiseasesReportDto> GetPhysicalDiseasesReport(DashboardDetailDto model)
        {
            var res = diseasesService.GetPhysicalReport(model);
            return res;
        } 
        [Route("GetDentalDiseasesReport")]
        [HttpPost]
        public List<DentalDiseasesReportDto> GetDentalDiseasesReport(DashboardDetailDto model)
        {
            var res = diseasesService.GetDentalDiseasesReport(model);
            return res;
        } 
        [Route("GetOphthalmologistDiseasesReport")]
        [HttpPost]
        public List<OphthalmologistDiseasesDto> GetOphthalmologistDiseasesReport(DashboardDetailDto model)
        {
            var res = diseasesService.GetOphthalmologistDiseasesReport(model);
            return res;
        } 
        [Route("GetSpeechReport")]
        [HttpPost]
        public List<SpeechDiseasesReportDto> GetSpeechReport(DashboardDetailDto model)
        {
            var res = diseasesService.GetSpeechReport(model);
            return res;
        } 
        [Route("GetEntReport")]
        [HttpPost]
        public List<ENTDiseasesReportDto> GetEntReport(DashboardDetailDto model)
        {
            var res = diseasesService.GetEntReport(model);
            return res;
        }
        [Route("GetMentalReport")]
        [HttpPost]
        public List<MentalDiseasesReportDto> GetMentalReport(DashboardDetailDto model)
        {
            var res = diseasesService.GetMentalReport(model);
            return res;
        }
    }
}
