using SpecialChildrenDashboard_Api.BAL.ViewModel;
using SpecialChildrenDashboard_Api.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.Interface
{
    public interface IDiseases
    {
 
        public List<PhysicalDiseasesReportDto> GetPhysicalReport(DashboardDetailDto model);
        public List<DentalDiseasesReportDto> GetDentalDiseasesReport(DashboardDetailDto model);
        public List<OphthalmologistDiseasesDto> GetOphthalmologistDiseasesReport(DashboardDetailDto model);
        public List<SpeechDiseasesReportDto> GetSpeechReport(DashboardDetailDto model);
        public List<ENTDiseasesReportDto> GetEntReport(DashboardDetailDto model);
        public List<MentalDiseasesReportDto> GetMentalReport(DashboardDetailDto model);


    }
}
