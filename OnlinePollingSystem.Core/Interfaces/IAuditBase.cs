﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePollingSystem.Core.Interfaces
{
    public interface IAuditBase
    {
        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Modified { get; set; }
    }
}
