using SpecialChildrenDashboard_Api.BAL.Interface;
using SpecialChildrenDashboard_Api.DAL.Context;
using SpecialChildrenDashboard_Api.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.Service
{
    public class EventService :IEventService
    {
        private readonly SpecialChildrenContext SpecialChildrenDb;

        public EventService(SpecialChildrenContext SpecialChildrenDb)
        {
            this.SpecialChildrenDb = SpecialChildrenDb;
        }
        public List<ScreeningType> EventList()
        {
            var res = SpecialChildrenDb.ScreeningTypes.ToList();
            return res;
        }
    }
}
