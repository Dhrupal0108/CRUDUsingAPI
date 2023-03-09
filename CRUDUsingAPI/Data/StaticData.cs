using System.Net;
using CRUDUsingAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using CRUDUsingAPI.Data;
using static System.Net.WebRequestMethods;

namespace CRUDUsingAPI.Data
{
    public class StaticData
    {
        public const string API_URL = "http://techext-001-site2.atempurl.com/api/UserInfo/";
    }
}
