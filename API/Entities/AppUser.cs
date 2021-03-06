using System;
using System.Collections.Generic;

namespace API.Entities
{
    public class AppUser
    {
        public Guid Id { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Email { get; set; }
        public string Dni { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }

        public string Position { get; set; }

        /*public string SecretKeyHmac { get; set; }*/
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /*Relacion con la tabla documents*/
        public ICollection<Document> Documents { get; set; }
        /*Relacion con la tabla Roles*/

        public ICollection<UserRole> UserRoles { get; set; }
    }
}