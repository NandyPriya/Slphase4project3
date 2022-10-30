using System.ComponentModel.DataAnnotations;

namespace BankDemo.Models
{
    public class LoginClass
    {
        [Required]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
