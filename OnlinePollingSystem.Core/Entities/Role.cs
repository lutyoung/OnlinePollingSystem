using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePollingSystem.Core.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
