﻿using Microsoft.AspNetCore.Mvc;

using System;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authentication;
using SpecialChildrenDashboard_Api.DAL.Context;
using SpecialChildrenDashboard_Api.BAL.Interface;

namespace SpecialChildrenDashboard_Api.Controllers
{
    [Route("api/Root")]
    [ApiController]
    [AllowAnonymous]
    public class RootController : Controller
    {
        private readonly SpecialChildrenContext db;
        private readonly IEventService eventService;
        public RootController(SpecialChildrenContext context,  IEventService eventService)
        {
            db = context;
            this.eventService = eventService;
        }


        [HttpGet]
        [Route("GetDivisions")]
        public async Task<IActionResult> GetDivisionsAsync()
        {
            var res = db.Locations.Where(x => x.PKCODE.Length == 3).ToList();
            return Ok(res);
        }
        [HttpGet]
        [Route("GetDistricts/{code}")]
        public IActionResult GetDistricts(string code)
        {
            return Ok(db.Locations.Where(x => x.PKCODE.StartsWith(code) && x.PKCODE.Length == 6).ToList());
        }

        [HttpGet]
        [Route("GetTehsils/{code}")]
        public IActionResult GetTehsils(string code)
        {
            return Ok(db.Locations.Where(x => x.PKCODE.StartsWith(code) && x.PKCODE.Length == 9).ToList());
        }
        [HttpGet]
        [Route("GetSchools/{code}")]
        public IActionResult GetSchools(string code)
        {
            var res = db.Schools.Where(x => x.TehsilId.StartsWith(code)).ToList();
            return Ok(res);
        }
        [HttpGet]
        [Route("GetEvents")]
        public async Task<IActionResult> GetEvents()
        {
            var res = eventService.EventList();
            return Ok(res);
        }



    }
}
