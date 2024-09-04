using System.ComponentModel.DataAnnotations;

namespace TaskIdentity.DTOS
{
    public class DtoNewUser
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public string PhoneNumber { get; set; }
       
    }
}
