using OnlinePollingSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePollingSystem.Core.Entities
{
    public class BaseEntity : ISoftDeletable, IAuditBase
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
