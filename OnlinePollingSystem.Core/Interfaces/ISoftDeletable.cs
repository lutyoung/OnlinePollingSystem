using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePollingSystem.Core.Interfaces
{
    public interface ISoftDeletable
    {
        public bool IsDeleted { get; set; }
    }
}
