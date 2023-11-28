

namespace Surface_Entities.DTOs
{
    public class EmailListDTO
    {
        public List<EmailDTO> EmailList { get; set; } = new List<EmailDTO>();
    }

    public class EmailDTO
    {
        public string Email { get; set; } = null!;
        public string Avatar { get; set; } = string.Empty;
    }
}
