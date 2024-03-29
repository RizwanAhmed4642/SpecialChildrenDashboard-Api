﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SpecialChildrenDashboard_Api.BAL.Helper;
using SpecialChildrenDashboard_Api.BAL.Interface;
using SpecialChildrenDashboard_Api.BAL.ViewModel;
using SpecialChildrenDashboard_Api.DAL.Context;
using SpecialChildrenDashboard_Api.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.Service
{
    public class CounterDashboard : ICounterDashboard
    {
        private readonly SpecialChildrenContext SpecialChildrenDb;

        public CounterDashboard(SpecialChildrenContext SpecialChildrenDb)
        {
            this.SpecialChildrenDb = SpecialChildrenDb;
        }

        public DashboardCounter GetCounterDashboard(DashboardDto model)
        {
            if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId == 0 && string.IsNullOrEmpty(model.Location))
            {
                var _resultModel = SpecialChildrenDb.DashboardCounters.FirstOrDefault();

                return _resultModel;
            }
            else if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0 && !string.IsNullOrEmpty(model.Location))
            {
                SqlParameter param;
                List<DashboardCounter> _resultModel = new List<DashboardCounter>();
                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("Sp_DashboardCountWithLocationEvent", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@Location", model.Location);
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);


                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<DashboardCounter>(res, false).AsQueryable();
                var list = resultList.ToList();

                DashboardCounter _DashboardCounter = list.FirstOrDefault();

                //sqlDataReader.Close();
                sqlConnection.Close();

                return _DashboardCounter;

            }
            else if (!string.IsNullOrEmpty(model.DateFrom) && !string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0 && !string.IsNullOrEmpty(model.Location))
            {
                SqlParameter param;
                List<DashboardCounter> _resultModel = new List<DashboardCounter>();
                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("Sp_DashboardCountWithLocationEventDate", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@Location", model.Location);
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
                sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);


                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<DashboardCounter>(res, false).AsQueryable();
                var list = resultList.ToList();

                DashboardCounter _DashboardCounter = list.FirstOrDefault();

                //sqlDataReader.Close();
                sqlConnection.Close();

                return _DashboardCounter;

            }
            else if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId == 0 && !string.IsNullOrEmpty(model.Location))
            {

                SqlParameter param;
                List<DashboardCounter> _resultModel = new List<DashboardCounter>();
                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("Sp_DashboardCountWithLocation", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@Location", model.Location);



                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<DashboardCounter>(res, false).AsQueryable();
                var list = resultList.ToList();

                DashboardCounter _DashboardCounter = list.FirstOrDefault();

                //sqlDataReader.Close();
                sqlConnection.Close();

                return _DashboardCounter;
            }

            else if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
            {

                SqlParameter param;
                List<DashboardCounter> _resultModel = new List<DashboardCounter>();
                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("dbo.Sp_DashboardCountWithEventId", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);



                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<DashboardCounter>(res, false).AsQueryable();
                var list = resultList.ToList();

                DashboardCounter _DashboardCounter = list.FirstOrDefault();

                //sqlDataReader.Close();
                sqlConnection.Close();

                return _DashboardCounter;
            }
            else if (!string.IsNullOrEmpty(model.DateFrom) || !string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
            {

                SqlParameter param;
                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                List<DashboardCounter> _resultModel = new List<DashboardCounter>();
                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("dbo.Sp_DashboardCountDateEvent", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
                sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);


                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<DashboardCounter>(res, false).AsQueryable();
                var list = resultList.ToList();

                DashboardCounter _DashboardCounter = list.FirstOrDefault();

                //sqlDataReader.Close();
                sqlConnection.Close();

                return _DashboardCounter;
            }
            else
            {
                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                SqlParameter param;
                List<DashboardCounter> _resultModel = new List<DashboardCounter>();
                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("dbo.DashboardCountDate", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);


                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<DashboardCounter>(res, false).AsQueryable();
                var list = resultList.ToList();

                DashboardCounter _DashboardCounter = list.FirstOrDefault();

                //sqlDataReader.Close();
                sqlConnection.Close();

                return _DashboardCounter;
            }
        }

        public List<DashboardDetailCount> GetDashboardDetailCount(DashboardDetailDto model)
        
        {
            List<DashboardDetailCount> _resultModel = new List<DashboardDetailCount>();
            if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId == 0)
            {
                if (string.IsNullOrEmpty(model.Location))
                {
                    _resultModel = SpecialChildrenDb.DashboardDetailCounts.OrderBy(x => x.DistrictName).ToList();
                }
         
                else
                {
                    _resultModel = SpecialChildrenDb.DashboardDetailCounts.Where(x => x.TehsilId.StartsWith(model.Location)).OrderBy(x => x.DistrictName).ToList();


                }
                return _resultModel;

            }
            else if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
            {

                SqlParameter param;

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("dbo.Sp_DashboardDetailCountEvent", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);



                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<DashboardDetailCount>(res, false).AsQueryable();
                _resultModel = resultList.ToList();
                if (!string.IsNullOrEmpty(model.Location))
                {
                    _resultModel = resultList.Where(x => x.TehsilId.StartsWith(model.Location)).ToList();

                }


                //sqlDataReader.Close();
                sqlConnection.Close();

                return _resultModel;
            }
            else if (!string.IsNullOrEmpty(model.DateFrom) || !string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
            {

                SqlParameter param;
                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("Sp_DashboardDetailCountDateEvent", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
                sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);


                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<DashboardDetailCount>(res, false).AsQueryable();
                _resultModel = resultList.ToList();
                if (!string.IsNullOrEmpty(model.Location))
                {
                    _resultModel = resultList.Where(x => x.TehsilId.StartsWith(model.Location)).ToList();

                }


                //sqlDataReader.Close();
                sqlConnection.Close();

                return _resultModel;
            }
            else
            {
                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                SqlParameter param;

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("dbo.Sp_DashboardDetailCount", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);


                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<DashboardDetailCount>(res, false).AsQueryable();
                _resultModel = resultList.ToList();
                if (!string.IsNullOrEmpty(model.Location))
                {
                    _resultModel = resultList.Where(x => x.TehsilId.StartsWith(model.Location)).ToList();

                }


                //sqlDataReader.Close();
                sqlConnection.Close();

                return _resultModel;







            }

        }     
        public List<StudentScreeningDto> GetStudentScreeningReport(DashboardDetailDto model)
        {
                  List<StudentScreeningDto> _resultModel = new List<StudentScreeningDto>();
               if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0 && !string.IsNullOrEmpty(model.Location))
            {
                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                SqlParameter param;

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("Sp_RegisterAndScreeningReportLocationEvent", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
                sqlCommand.Parameters.AddWithValue("@Location", model.Location);



                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<StudentScreeningDto>(res, false).AsQueryable();
                _resultModel = resultList.ToList();
                if (!string.IsNullOrEmpty(model.Location))
                {
                    _resultModel = resultList.Where(x => x.TehsilId.StartsWith(model.Location)).ToList();

                }


                //sqlDataReader.Close();
                sqlConnection.Close();

                return _resultModel;
            }
            else if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0 && string.IsNullOrEmpty(model.Location))
            {

                SqlParameter param;

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("Sp_RegisterAndScreeningReportEvent", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);



                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<StudentScreeningDto>(res, false).AsQueryable();
                _resultModel = resultList.ToList();
                if (!string.IsNullOrEmpty(model.Location))
                {
                    _resultModel = resultList.Where(x => x.TehsilId.StartsWith(model.Location)).ToList();

                }


                //sqlDataReader.Close();
                sqlConnection.Close();

                return _resultModel;
            }
            else if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId == 0 && !string.IsNullOrEmpty(model.Location))
            {

                SqlParameter param;

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("[Sp_RegisterAndScreeningReportLocation]", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@Location", model.Location);



                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<StudentScreeningDto>(res, false).AsQueryable();
                _resultModel = resultList.ToList();
                if (!string.IsNullOrEmpty(model.Location))
                {
                    _resultModel = resultList.Where(x => x.TehsilId.StartsWith(model.Location)).ToList();

                }


                //sqlDataReader.Close();
                sqlConnection.Close();

                return _resultModel;
            }
            else if (!string.IsNullOrEmpty(model.DateFrom) && !string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0 && !string.IsNullOrEmpty(model.Location))
            {

                SqlParameter param;
                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("Sp_RegisterAndScreeningReportLocationEventDate", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
                sqlCommand.Parameters.AddWithValue("@Location", model.Location);
                sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);


                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<StudentScreeningDto>(res, false).AsQueryable();
                _resultModel = resultList.ToList();
                if (!string.IsNullOrEmpty(model.Location))
                {
                    _resultModel = resultList.Where(x => x.TehsilId.StartsWith(model.Location)).ToList();

                }


                //sqlDataReader.Close();
                sqlConnection.Close();

                return _resultModel;
            }
            else if (!string.IsNullOrEmpty(model.DateFrom) && !string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0 && string.IsNullOrEmpty(model.Location))
            {

                SqlParameter param;
                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("Sp_RegisterAndScreeningReportEventDate", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);         
                sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);


                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<StudentScreeningDto>(res, false).AsQueryable();
                _resultModel = resultList.ToList();
                if (!string.IsNullOrEmpty(model.Location))
                {
                    _resultModel = resultList.Where(x => x.TehsilId.StartsWith(model.Location)).ToList();

                }


                //sqlDataReader.Close();
                sqlConnection.Close();

                return _resultModel;
            }
            else
            {
                SqlParameter param;
                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("V_RegisterAndScreeningReport", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
               

                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<StudentScreeningDto>(res, false).AsQueryable();
                _resultModel = resultList.ToList();
                if (!string.IsNullOrEmpty(model.Location))
                {
                    _resultModel = resultList.Where(x => x.TehsilId.StartsWith(model.Location)).ToList();

                }


                //sqlDataReader.Close();
                sqlConnection.Close();

                return _resultModel;
 }
}



        public List<View_StudentRegistration> GetStudentList(StudentDto model)
        {
            List<View_StudentRegistration> _resultModel = new List<View_StudentRegistration>();
            string _school = Convert.ToString(model.SchoolId);
            string _storeprocedure = "";
            if (model.Param == "TS")
                _storeprocedure = "Sp_StudentSchoolDateEvent";
            else if (model.Param == "TPP")
                _storeprocedure = "Sp_StudentPhysicalParameter";
            else if (model.Param == "TDT")
                _storeprocedure = "Sp_Dental";
            else if (model.Param == "TO")
                _storeprocedure = "Sp_Ophthalmologist";
            else if (model.Param == "TST")
                _storeprocedure = "Sp_SpeechTherapy";
            else if (model.Param == "TENT")
                _storeprocedure = "Sp_ENT";
            else if (model.Param == "TPSY")
                _storeprocedure = "Sp_Psychologist";
            else
                _storeprocedure = "Sp_StudentSchoolDateEvent";

           
           
            SqlParameter param;

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
            if (model.DateTo != null)
            {
                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
            }
            //sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
            sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
            sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
            sqlCommand.Parameters.AddWithValue("@SchoolId", model.SchoolId);



            sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                _resultModel = resultList.ToList();



                //sqlDataReader.Close();
                sqlConnection.Close();

            
                return _resultModel;
         


        }

    }





}

