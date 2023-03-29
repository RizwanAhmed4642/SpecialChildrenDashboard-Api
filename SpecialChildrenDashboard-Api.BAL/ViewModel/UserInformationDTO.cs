using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChildrenDashboard_Api.BAL.ViewModel
{
    public class UserInformationDTO
    {
        public string access_token { get; set; }
        //public string token_type { get; set; }
        //public string expires_in { get; set; }
        public string userName { get; set; }
        public userData user { get; set; } = new userData();
        //public Array perms { get; set; }
        //public List<navData> nav { get; set; }

        public class userData
        {
            public string Id { get; set; }         
            public string UserName { get; set; }
            public string Category { get; set; }
            public string ProfileImage { get; set; }
            public string Template { get; set; }
            public string Permissions { get; set; }
            public string Location { get; set; }
             public string FullName { get; set; }
       
            public string RoleName { get; set; }
     
        }
        //public class navData
        //{
        //    public int Id { get; set; }
        //    public string? Name { get; set; }
        //    public bool? Value { get; set; }
        //    public string? Url { get; set; }
        //    public string? Icon { get; set; }
        //    public string? Badge { get; set; }
        //    public string? OrderBy { get; set; }
        //}
    }
}
