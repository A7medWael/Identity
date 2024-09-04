using System.ComponentModel.DataAnnotations;

namespace TaskIdentity.DTOS
{
    public class LoginDto
    {
        public string UserName { get; set; }
        
        public string Password { get; set; }
    }
}
