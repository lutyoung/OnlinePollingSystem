using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePollingSystem.Core.Entities
{
    public class User :BaseEntity
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public IEnumerable<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
