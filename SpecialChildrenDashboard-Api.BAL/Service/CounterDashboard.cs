using Microsoft.Data.SqlClient;
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
            if (model.DateFrom == null || model.DateTo == null)
            {
                var _resultModel = SpecialChildrenDb.DashboardCounters.FirstOrDefault();

                return _resultModel;
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
            if (string.IsNullOrEmpty(model.DateFrom) || string.IsNullOrEmpty(model.DateTo))
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

        public List<View_StudentRegistration> GetStudentList(StudentDto model)
        {
            List<View_StudentRegistration> _resultModel = new List<View_StudentRegistration>();
            string _school = Convert.ToString(model.SchoolId);         
            SqlParameter param;

            using var _db = new SpecialChildrenContext();
            using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

            using SqlCommand sqlCommand = new SqlCommand("Sp_StudentSchool", sqlConnection)
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

    }





}

