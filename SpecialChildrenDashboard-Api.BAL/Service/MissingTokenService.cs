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
    public class MissingTokenService : IMissingToken
    {
        private readonly SpecialChildrenContext SpecialChildrenDb;

        public MissingTokenService(SpecialChildrenContext SpecialChildrenDb)
        {
            this.SpecialChildrenDb = SpecialChildrenDb;
        }

        public List<View_MissingTokenCount> GetMisingToken(DashboardDetailDto model)
        {
            List<View_MissingTokenCount> _resultModel = new List<View_MissingTokenCount>();
            if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId == 0 && string.IsNullOrEmpty(model.Location))
            {
                if (string.IsNullOrEmpty(model.Location))
                {
                    _resultModel = SpecialChildrenDb.View_MissingTokenCounts.OrderBy(x => x.DistrictName).ToList();
                }
                else
                {
                    _resultModel = SpecialChildrenDb.View_MissingTokenCounts.Where(x => x.TehsilId.StartsWith(model.Location)).OrderBy(x => x.DistrictName).ToList();


                }
                return _resultModel;

            }
          else if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId == 0 && !string.IsNullOrEmpty(model.Location))
            {
                SqlParameter param;

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("SP_MisingTokenCounterLocation", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@Location", model.Location);



                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<View_MissingTokenCount>(res, false).AsQueryable();
                _resultModel = resultList.ToList();
                //if (!string.IsNullOrEmpty(model.Location))
                //{
                //    _resultModel = resultList.Where(x => x.TehsilId.StartsWith(model.Location)).ToList();

                //}


                //sqlDataReader.Close();
                sqlConnection.Close();

                return _resultModel;
            }
            else if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0 && !string.IsNullOrEmpty(model.Location))
            {
                SqlParameter param;

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("SP_MisingTokenCounterLocation", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@Location", model.Location);



                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<View_MissingTokenCount>(res, false).AsQueryable();
                _resultModel = resultList.ToList();
                //if (!string.IsNullOrEmpty(model.Location))
                //{
                //    _resultModel = resultList.Where(x => x.TehsilId.StartsWith(model.Location)).ToList();

                //}


                //sqlDataReader.Close();
                sqlConnection.Close();

                return _resultModel;
            }
            else if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0 && !string.IsNullOrEmpty(model.Location))
            {
                SqlParameter param;

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("SP_MisingTokenCounterLocationEvent", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@Location", model.Location);
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);


                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<View_MissingTokenCount>(res, false).AsQueryable();
                _resultModel = resultList.ToList();
                //if (!string.IsNullOrEmpty(model.Location))
                //{
                //    _resultModel = resultList.Where(x => x.TehsilId.StartsWith(model.Location)).ToList();

                //}


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

                using SqlCommand sqlCommand = new SqlCommand("SP_MisingTokenCounterLocationEventDate", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@Location", model.Location);
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
                sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);


                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<View_MissingTokenCount>(res, false).AsQueryable();
                _resultModel = resultList.ToList();
                //if (!string.IsNullOrEmpty(model.Location))
                //{
                //    _resultModel = resultList.Where(x => x.TehsilId.StartsWith(model.Location)).ToList();

                //}


                //sqlDataReader.Close();
                sqlConnection.Close();

                return _resultModel;
            }
            else if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
            {

                SqlParameter param;

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("SP_MisingTokenCounterEvent", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);



                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<View_MissingTokenCount>(res, false).AsQueryable();
                _resultModel = resultList.ToList();
                if (!string.IsNullOrEmpty(model.Location))
                {
                    _resultModel = resultList.Where(x => x.TehsilId.StartsWith(model.Location)).ToList();

                }


                //sqlDataReader.Close();
                sqlConnection.Close();

                return _resultModel;
            }
            else if (!string.IsNullOrEmpty(model.DateFrom) && !string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
            {

                SqlParameter param;
                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("SP_MisingTokenCounterDatewithEvent", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
                sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);


                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<View_MissingTokenCount>(res, false).AsQueryable();
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

                using SqlCommand sqlCommand = new SqlCommand("dbo.SP_MisingTokenCounterDate", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);


                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<View_MissingTokenCount>(res, false).AsQueryable();
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
        public List<View_StudentRegistration> GetMixingStudentList(StudentDto model)
        {
            List<View_StudentRegistration> _resultModel = new List<View_StudentRegistration>();
            string _school = Convert.ToString(model.SchoolId);
          
            string _storeprocedure = "";


            {
                if (model.Param == "Physical  Assessment")
                {
                    if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId == 0)
                    {

                        _storeprocedure = "Sp_MisingPhysicalParametersEventLocationSchool";
                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);


                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                        return _resultModel;


                    }
                    else if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
                    {
                        _storeprocedure = "Sp_MisingPhysicalParametersEventLocationSchoolScreeningType";

                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);
                        sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);


                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                        return _resultModel;

                    }

                    else if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && !string.IsNullOrEmpty(model.DateFrom) && !string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
                    {
                        _storeprocedure = "Sp_MisingPhysicalParametersEventLocationSchoolScreeningTypeDate";
                        var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);
                        sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                        sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
                        sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);

                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                    }
                }

                else if (model.Param == "Dental  Assessment")
                { 
                    if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId == 0)
                    {

                        _storeprocedure = "Sp_MisingDentalEventLocationSchool";
                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);


                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                        return _resultModel;


                    }
                    else if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
                    {
                        _storeprocedure = "Sp_MisingDentalEventLocationSchoolScreeningType";

                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);
                        sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);


                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                        return _resultModel;

                    }

                    else if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && !string.IsNullOrEmpty(model.DateFrom) && !string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
                    {
                        _storeprocedure = "Sp_MisingDentalEventLocationSchoolScreeningTypeDate";
                        var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);
                        sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                        sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
                        sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);

                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                    }
            }
                else if (model.Param == "Ophthalmologist  Assessment")
                {
                    if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId == 0)
                    {

                        _storeprocedure = "Sp_MisingOphthalmologistEventLocationSchool";
                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);


                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                        return _resultModel;


                    }
                    else if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
                    {
                        _storeprocedure = "Sp_MisingOphthalmologistEventLocationSchoolScreeningType";

                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);
                        sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);


                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                        return _resultModel;

                    }

                    else if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && !string.IsNullOrEmpty(model.DateFrom) && !string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
                    {
                        _storeprocedure = "Sp_MisingOphthalmologistEventLocationSchoolScreeningTypeDate";
                        var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);
                        sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                        sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
                        sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);

                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                    }
                }
                else if (model.Param == "SpeechTherapist  Assessment")
                {
                    if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId == 0)
                    {

                        _storeprocedure = "Sp_MisingSpeechTherapistEventLocationSchool";
                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);


                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                        return _resultModel;


                    }
                    else if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
                    {
                        _storeprocedure = "Sp_MisingSpeechTherapistEventLocationSchoolScreeningType";

                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);
                        sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);


                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                        return _resultModel;

                    }

                    else if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && !string.IsNullOrEmpty(model.DateFrom) && !string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
                    {
                        _storeprocedure = "Sp_MisingSpeechTherapistEventLocationSchoolScreeningTypeDate";
                        var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);
                        sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                        sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
                        sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);

                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                    }
                }
         
                else if (model.Param == "Ent  Assessment")
                {
                    if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId == 0)
                    {

                        _storeprocedure = "Sp_MisingEntEventLocationSchool";
                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);


                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                        return _resultModel;


                    }
                    else if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
                    {
                        _storeprocedure = "Sp_MisingEntEventLocationSchoolScreeningType";

                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);
                        sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);


                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                        return _resultModel;

                    }

                    else if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && !string.IsNullOrEmpty(model.DateFrom) && !string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
                    {
                        _storeprocedure = "Sp_MisingEntEventLocationSchoolScreeningTypeDate";
                        var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);
                        sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                        sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
                        sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);

                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                    }

                }
                else if (model.Param == "Psychologist Assessment")
                    if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId == 0)
                    {

                        _storeprocedure = "Sp_MisingPsychologistEventLocationSchool";
                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);


                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                        return _resultModel;


                    }
                    else if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
                    {
                        _storeprocedure = "Sp_MisingPsychologistEventLocationSchoolScreeningType";

                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);
                        sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);


                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                        return _resultModel;

                    }

                    else if (!string.IsNullOrEmpty(_school) && !string.IsNullOrEmpty(model.locationId) && !string.IsNullOrEmpty(model.DateFrom) && !string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
                    {
                        _storeprocedure = "Sp_MisingPsychologistEventLocationSchoolScreeningTypeDate";
                        var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                        SqlParameter param;

                        using var _db = new SpecialChildrenContext();
                        using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                        using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                        {
                            CommandType = System.Data.CommandType.StoredProcedure,
                        };
                        sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                        sqlCommand.Parameters.AddWithValue("@SchoolId", _school);
                        sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                        sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
                        sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);

                        sqlConnection.Open();

                        var res = sqlCommand.ExecuteReader();
                        var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                        _resultModel = resultList.ToList();



                        //sqlDataReader.Close();
                        sqlConnection.Close();
                    }

                else
                {
                    var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                    SqlParameter param;

                    using var _db = new SpecialChildrenContext();
                    using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                    using SqlCommand sqlCommand = new SqlCommand(_storeprocedure, sqlConnection)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure,
                    };
                    sqlCommand.Parameters.AddWithValue("@LocationId", model.locationId);
                    sqlCommand.Parameters.AddWithValue("@SchoolId", _school);
                    sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                    sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
                    sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);

                    sqlConnection.Open();

                    var res = sqlCommand.ExecuteReader();
                    var resultList = PropertyMapper.ToList<View_StudentRegistration>(res, false).AsQueryable();
                    _resultModel = resultList.ToList();



                    //sqlDataReader.Close();
                    sqlConnection.Close();
                }
             


                return _resultModel;
            }
     


        }




        public List<MissingTokenReportDto> GetMixingTokenDetail(DashboardDetailDto model)
        {
            List<MissingTokenReportDto> _resultModel = new List<MissingTokenReportDto>();
            if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0 && string.IsNullOrEmpty(model.Location))
            {


                SqlParameter param;

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("SP_MisingTokenDetailReportEvent", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };

                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);

                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<MissingTokenReportDto>(res, false).AsQueryable();
                _resultModel = resultList.ToList();



                //sqlDataReader.Close();
                sqlConnection.Close();


                return _resultModel;
            }
       
          else  if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId == 0 && !string.IsNullOrEmpty(model.Location))
            {


                SqlParameter param;

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("SP_MisingTokenDetailReportLocation", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };

                sqlCommand.Parameters.AddWithValue("@Location", model.Location);

                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<MissingTokenReportDto>(res, false).AsQueryable();
                _resultModel = resultList.ToList();



                //sqlDataReader.Close();
                sqlConnection.Close();


                return _resultModel;
            }
            else if (!string.IsNullOrEmpty(model.DateFrom) && !string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId 
                >0 && !string.IsNullOrEmpty(model.Location))
            {


                SqlParameter param;
                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("SP_MisingTokenDetailReportEventLocationDate", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };

                sqlCommand.Parameters.AddWithValue("@Location", model.Location);
                sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<MissingTokenReportDto>(res, false).AsQueryable();
                _resultModel = resultList.ToList();



                //sqlDataReader.Close();
                sqlConnection.Close();


                return _resultModel;
            }
            else if (string.IsNullOrEmpty(model.DateFrom) && string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId
              > 0 && !string.IsNullOrEmpty(model.Location))
            {


                SqlParameter param;
                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("SP_MisingTokenDetailReportEventLocation", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };

                sqlCommand.Parameters.AddWithValue("@Location", model.Location);
          
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);
                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<MissingTokenReportDto>(res, false).AsQueryable();
                _resultModel = resultList.ToList();



                //sqlDataReader.Close();
                sqlConnection.Close();


                return _resultModel;
            }
            else if (!string.IsNullOrEmpty(model.DateFrom) && !string.IsNullOrEmpty(model.DateTo) && model.ScreeningTypeId > 0)
            {

                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("SP_MisingTokenDetailReport", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);
                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", model.ScreeningTypeId);

                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<MissingTokenReportDto>(res, false).AsQueryable();
                _resultModel = resultList.ToList();



                //sqlDataReader.Close();
                sqlConnection.Close();


                return _resultModel;
            }
            else
            {
                int ScreeningTypeId = 1;


                SqlParameter param;

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("SP_MisingTokenDetailReportEvent", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };

                sqlCommand.Parameters.AddWithValue("@ScreeningTypeId", ScreeningTypeId);

                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<MissingTokenReportDto>(res, false).AsQueryable();
                _resultModel = resultList.ToList();



                //sqlDataReader.Close();
                sqlConnection.Close();


                return _resultModel;

            }


        }


    }
}
