using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePollingSystem.Core.Entities
{
    public class ContestantPoll:BaseEntity
    {
        public int ContestantId { get; set; }

        public Contestant Contestant { get; set; }

        public int PollId { get; set; }

        public Poll Poll { get; set; }
    }
}
