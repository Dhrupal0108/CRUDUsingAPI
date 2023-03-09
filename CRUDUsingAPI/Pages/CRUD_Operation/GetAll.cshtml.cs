using CRUDUsingAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using CRUDUsingAPI.Data;
using System.Net;

namespace CRUDUsingAPI.Pages.CRUD_Operation
{
    public class GetAllModel : PageModel
    {
        public List<UserInfoModel> UserInfo { get; set; }
        [HttpGet]
        [ValidateAntiForgeryToken]
        public void OnGet()
        {

            //Fetch the JSON string from URL.
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.SystemDefault;
            string json = (new WebClient()).DownloadString(StaticData.API_URL+"GetTeamMembers");

            //binding the data with model
            UserInfo = JsonConvert.DeserializeObject<List<UserInfoModel>>(json);

        }
    }
}
