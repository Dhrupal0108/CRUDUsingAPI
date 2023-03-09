using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CRUDUsingAPI.Model
{
    public class UserCRUDModel
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
    }
}
