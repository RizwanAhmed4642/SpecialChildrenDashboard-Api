
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SpecialChildrenDashboard_Api.BAL.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace BAS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
       

     

        [Route("Login/{username}/{password}")]
        [HttpGet]
        public async Task<UserInformationDTO> Login(string username, string password)
        {
            try
            {
                UserInformationDTO userInformationDTO = new UserInformationDTO();
                var datai1 = new Dictionary<string, string>
                {
                {"username", username},
                {"password", password},
                {"grant_type", "password"}
            };
                //dynamic result = null;
                var url = "https://scapi.pshealthpunjab.gov.pk/api/token";
                using var client = new HttpClient();
                var response = await client.PostAsync(url, new FormUrlEncodedContent(datai1));
                if (response.IsSuccessStatusCode)
                {
                    //var token = await response.Content.ReadAsStringAsync();
                    //var result = (dynamic)JsonConvert.DeserializeObject<object>(token);
                    var token = await response.Content.ReadAsStringAsync();
                    dynamic tempUserInformationDTO = JsonConvert.DeserializeObject(token);

                    userInformationDTO.access_token = tempUserInformationDTO.access_token;
                    userInformationDTO.userName = tempUserInformationDTO.userName;
                    userInformationDTO.user.Id = tempUserInformationDTO.Id;
                    userInformationDTO.user.FullName = tempUserInformationDTO.FullName;
                    userInformationDTO.user.Location = tempUserInformationDTO.Location;
                    userInformationDTO.user.Category = tempUserInformationDTO.Category;
                    userInformationDTO.user.RoleName = tempUserInformationDTO.RoleName;
                    userInformationDTO.user.Permissions = tempUserInformationDTO.Permissions;
                  
                    return userInformationDTO;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //[Route("GetDutyRosterForMobileApp/{hfmisCode}")]
        //[HttpGet]
        //public async Task<Response<DutyRosterDetailViewForMobileApp>> GetDutyRosterForMobileApp(String hfmisCode)
        //{
        //    var profile = mobileAppService.GetDutyRosterForMobileApp(hfmisCode);
        //    return profile.Result;
        //}
    }
}
