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
    public class DeviceService : IDevices
    {
        private readonly SpecialChildrenContext SpecialChildrenDb;

        public DeviceService(SpecialChildrenContext SpecialChildrenDb)
        {
            this.SpecialChildrenDb = SpecialChildrenDb;
        }
        public List<V_PhysicalDevicesReport> GetPhysicalDevicesReport(DashboardDetailDto model)
        {
            List<V_PhysicalDevicesReport> _resultModel = new List<V_PhysicalDevicesReport>();
            if (string.IsNullOrEmpty(model.DateFrom) || string.IsNullOrEmpty(model.DateTo))
            {
                if (string.IsNullOrEmpty(model.Location))
                {
                    _resultModel = SpecialChildrenDb.V_PhysicalDevicesReports.OrderBy(x => x.DistrictName).ToList();
                }
                else
                {
                    _resultModel = SpecialChildrenDb.V_PhysicalDevicesReports.Where(x => x.TehsilId.StartsWith(model.Location)).OrderBy(x => x.DistrictName).ToList();


                }
                return _resultModel;

            }
            else
            {
                var _dateTo = (Convert.ToDateTime(model.DateTo)).AddDays(1);
                SqlParameter param;

                using var _db = new SpecialChildrenContext();
                using SqlConnection sqlConnection = (SqlConnection)_db.Database.GetDbConnection();

                using SqlCommand sqlCommand = new SqlCommand("dbo.PhysicalDevicesReport", sqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                };
                sqlCommand.Parameters.AddWithValue("@DateFrom", model.DateFrom);
                sqlCommand.Parameters.AddWithValue("@DateTo", _dateTo);


                sqlConnection.Open();

                var res = sqlCommand.ExecuteReader();
                var resultList = PropertyMapper.ToList<V_PhysicalDevicesReport>(res, false).AsQueryable();
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
    }
}
