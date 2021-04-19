using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePollingSystem.Core.Entities
{
    public class Vote : BaseEntity
    {
        public int ContestantId { get; set; }

        public Contestant Contestant { get; set; }

        public int PollId { get; set; }

        public Poll Poll { get; set; }

        public int VoterId { get; set; }

        public Voter Voter { get; set; }

        public int TotalCount { get; set; }
    }
}
