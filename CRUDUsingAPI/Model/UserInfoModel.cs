using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CRUDUsingAPI.Model
{
    public class UserInfoModel
    {
        [Key]
        public int id { get; set; }
        [DisplayName("User Name")]
        public string userName { get; set; }
        [EmailAddress]
        [DisplayName("Email Address")]
        public string emailAddress { get; set; }
        [DisplayName("Contact No.")]
        public string contactNo { get; set; }
        public string password { get; set; }
        public int userTypeId { get; set; }
        public string createdBy { get; set; }
        public DateTime? createdOn { get; set; }
        public string updatedby { get; set; }
        public DateTime? updatedOn { get; set; }
        public bool isDeleted { get; set; }
        public string forgotVarificationCode { get; set; } = null;
        public bool isActivate { get; set; }
        public DateTime? lastLoginDate { get; set; }
        public bool isAlreadyLoggedIn { get; set; }


        //public async void OnPostCallAPI()
        //{
        //    try
        //    {
        //        using (var client = new HttpClient())
        //        {
        //            HttpRequestMessage request = new HttpRequestMessage();
        //            request.RequestUri = new Uri(Baseurl);
        //            request.Method = HttpMethod.Get;
        //            request.Headers.Add("SecureApiKey", "12345");
        //            HttpResponseMessage response = await client.SendAsync(request);
        //            var responseString = await response.Content.ReadAsStringAsync();
        //            var statusCode = response.StatusCode;
        //            if (response.IsSuccessStatusCode)
        //            {
        //                //API call success, Do your action
        //            }

        //            else
        //            {
        //                //API Call Failed, Check Error Details
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}
    }
}
