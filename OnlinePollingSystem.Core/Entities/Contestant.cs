using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePollingSystem.Core.Entities
{
    public class Contestant:BaseEntity
    {
        public int PersonId { get; set; }

        public Person Person { get; set; }

        public Guid ContestantNumber { get; set; }

        public string Information { get; set; }

        public IEnumerable<ContestantPoll> ContestantPolls { get; set; } = new List<ContestantPoll>();

        public IEnumerable<Vote> Votes { get; set; } = new List<Vote>();
    }
}
