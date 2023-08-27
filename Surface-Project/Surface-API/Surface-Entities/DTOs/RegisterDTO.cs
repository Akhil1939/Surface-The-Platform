

namespace Surface_Entities.DTOs
{
    public class RegisterDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string LoginToken { get; set; }  
        public byte loginProviderId { get; set; }
    }
}
