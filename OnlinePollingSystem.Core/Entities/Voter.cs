using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePollingSystem.Core.Entities
{
    public class Voter : BaseEntity
    {
        public int PersonId { get; set; }

        public Person Person { get; set; }

        public Guid VoterNumber { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public IEnumerable<Vote> Votes { get; set; } = new List<Vote>();
    }
}
