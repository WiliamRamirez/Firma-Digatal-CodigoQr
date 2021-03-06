using System.Collections.Generic;

namespace API.DTOs
{
    public class RegisterDto
    {
        public string Username { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public string LastName { get; set; }
        public string Fullname { get; set; }
        public List<RoleDto> Roles { get; set; }
    }
}