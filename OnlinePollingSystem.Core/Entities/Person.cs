using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePollingSystem.Core.Entities
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string ProfilePic { get; set; }
    }
}
