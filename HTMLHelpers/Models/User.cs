using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace HTMLHelpers.Models
{
    public class User
    {
        [Display(Name = "Full Name")]
        public String? Name { get; set; }
        
        [Display(Name = "Email Address")]

        public String? Email { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public string? Gender { get; set; }
        public bool Issubscribed { get; set; }
        public String? Country { get; set; }
        public  String? Skills { get; set; }

    }
}
