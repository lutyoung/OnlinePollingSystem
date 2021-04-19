using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePollingSystem.Core.Entities
{
    public class Poll:BaseEntity
    {
        public string Name { get; set; }

        public IEnumerable<ContestantPoll> ContestantPolls { get; set; } = new List<ContestantPoll>();

        public IEnumerable<Vote> Votes { get; set; } = new List<Vote>();
    }
}
