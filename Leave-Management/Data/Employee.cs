using Microsoft.AspNetCore.Identity;
using System;

namespace Leave_Management.Data
{
    public class Employee : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }

        [PersonalData]
        public int TaxId { get; set; }

        [PersonalData]
        public DateTime DateOfBirth { get; set; }

        public DateTime DateJoined { get; set; }
    }
}
