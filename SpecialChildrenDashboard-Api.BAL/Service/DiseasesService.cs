using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SpecialChildrenDashboard_Api.BAL.Helper;
using SpecialChildrenDashboard_Api.BAL.Interface;
using SpecialChildrenDashboard_Api.BAL.ViewModel;
using SpecialChildrenDashboard_Api.DAL.Context;
using SpecialChildrenDashboard_Api.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.Service
{
    public class DiseasesService : IDiseases
    {
        private readonly SpecialChildrenContext SpecialChildrenDb;

        public DiseasesService(SpecialChildrenContext SpecialChildrenDb)
        {
            this.SpecialChildrenDb = SpecialChildrenDb;
        }

        public List<PhysicalDiseasesReportDto> GetPhysicalReport(DashboardDetailDto model)
        {
            List<PhysicalDiseasesReportDto> _resultModel = new List<PhysicalDiseasesReportDto>();

            if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateFrom))
            {
                model.DateFrom = DateTime.Now.ToString("yyyy-MM-dd");
                model.DateTo = DateTime.Now.ToString("yyyy-MM-dd");
            }
                   
          



                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                SqlParameter param;

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("SP_PhysicalDiseasesReportAllCount", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };

                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
                sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
                sqlCommand.Parameters.AddWithValue("@LocationId", model.Location);


                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<PhysicalDiseasesReportDto>(res, false).AsQueryable();
                _resultModel = resultList.ToList();



                //sqlDataReader.Close();
                sqlConnection.Close();

                return _resultModel;


           
           


            






            

        }
        public List<DentalDiseasesReportDto> GetDentalDiseasesReport(DashboardDetailDto model)
        {
            List<DentalDiseasesReportDto> _resultModel = new List<DentalDiseasesReportDto>();

            if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateFrom))
            {
                model.DateFrom = DateTime.Now.ToString("yyyy-MM-dd");
                model.DateTo = DateTime.Now.ToString("yyyy-MM-dd");
            }





            var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
            SqlParameter param;

            using var _db = new SpecialChildrenContext();
            using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

            using SqlCommand sqlCommand = new SqlCommand("SP_DentalDiseasesReportAllCount", sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure,
            };

            sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
            sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
            sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
            sqlCommand.Parameters.AddWithValue("@LocationId", model.Location);


            sqlConnection.Open();

            var res = sqlCommand.ExecuteReader();
            var resultList = PropertyMapper.ToList<DentalDiseasesReportDto>(res, false).AsQueryable();
            _resultModel = resultList.ToList();



            //sqlDataReader.Close();
            sqlConnection.Close();

            return _resultModel;














          
          }
        public List<OphthalmologistDiseasesDto> GetOphthalmologistDiseasesReport(DashboardDetailDto model)
        {
            List<OphthalmologistDiseasesDto> _resultModel = new List<OphthalmologistDiseasesDto>();

            if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateFrom))
            {
                model.DateFrom = DateTime.Now.ToString("yyyy-MM-dd");
                model.DateTo = DateTime.Now.ToString("yyyy-MM-dd");
            }





            var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
            SqlParameter param;

            using var _db = new SpecialChildrenContext();
            using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

            using SqlCommand sqlCommand = new SqlCommand("SP_OphthalmologistDiseasesReportAllCount", sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure,
            };

            sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
            sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
            sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
            sqlCommand.Parameters.AddWithValue("@LocationId", model.Location);


            sqlConnection.Open();

            var res = sqlCommand.ExecuteReader();
            var resultList = PropertyMapper.ToList<OphthalmologistDiseasesDto>(res, false).AsQueryable();
            _resultModel = resultList.ToList();



            //sqlDataReader.Close();
            sqlConnection.Close();

            return _resultModel;

           
        }
        public List<SpeechDiseasesReportDto> GetSpeechReport(DashboardDetailDto model)
        {
            List<SpeechDiseasesReportDto> _resultModel = new List<SpeechDiseasesReportDto>();

            if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateFrom))
            {
                model.DateFrom = DateTime.Now.ToString("yyyy-MM-dd");
                model.DateTo = DateTime.Now.ToString("yyyy-MM-dd");
            }





            var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
            SqlParameter param;

            using var _db = new SpecialChildrenContext();
            using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

            using SqlCommand sqlCommand = new SqlCommand("SP_SpeechDiseasesReportAllCount", sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure,
            };

            sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
            sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
            sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
            sqlCommand.Parameters.AddWithValue("@LocationId", model.Location);


            sqlConnection.Open();

            var res = sqlCommand.ExecuteReader();
            var resultList = PropertyMapper.ToList<SpeechDiseasesReportDto>(res, false).AsQueryable();
            _resultModel = resultList.ToList();



            //sqlDataReader.Close();
            sqlConnection.Close();

            return _resultModel;



           

            
        }
        public List<ENTDiseasesReportDto> GetEntReport(DashboardDetailDto model)
        {
            List<ENTDiseasesReportDto> _resultModel = new List<ENTDiseasesReportDto>();

            if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateFrom))
            {
                model.DateFrom = DateTime.Now.ToString("yyyy-MM-dd");
                model.DateTo = DateTime.Now.ToString("yyyy-MM-dd");
            }





            var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
            SqlParameter param;

            using var _db = new SpecialChildrenContext();
            using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

            using SqlCommand sqlCommand = new SqlCommand("SP_ENTDiseasesReportAllCount", sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure,
            };

            sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
            sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
            sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
            sqlCommand.Parameters.AddWithValue("@LocationId", model.Location);


            sqlConnection.Open();

            var res = sqlCommand.ExecuteReader();
            var resultList = PropertyMapper.ToList<ENTDiseasesReportDto>(res, false).AsQueryable();
            _resultModel = resultList.ToList();



            //sqlDataReader.Close();
            sqlConnection.Close();

            return _resultModel;




          
        }
        public List<MentalDiseasesReportDto> GetMentalReport(DashboardDetailDto model)
        {
            List<MentalDiseasesReportDto> _resultModel = new List<MentalDiseasesReportDto>();

            if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateFrom))
            {
                model.DateFrom = DateTime.Now.ToString("yyyy-MM-dd");
                model.DateTo = DateTime.Now.ToString("yyyy-MM-dd");
            }





            var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
            SqlParameter param;

            using var _db = new SpecialChildrenContext();
            using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

            using SqlCommand sqlCommand = new SqlCommand("SP_MentalDiseasesReportAllCount", sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure,
            };

            sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
            sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
            sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
            sqlCommand.Parameters.AddWithValue("@LocationId", model.Location);


            sqlConnection.Open();

            var res = sqlCommand.ExecuteReader();
            var resultList = PropertyMapper.ToList<MentalDiseasesReportDto>(res, false).AsQueryable();
            _resultModel = resultList.ToList();



            //sqlDataReader.Close();
            sqlConnection.Close();

            return _resultModel;

        }
  
    }
}
