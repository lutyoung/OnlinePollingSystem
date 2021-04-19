using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePollingSystem.Core.Entities
{
    public class Admin:BaseEntity
    {
        public int PersonId { get; set; }

        public Person Person { get; set; }

        public Guid AdminNumber { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
