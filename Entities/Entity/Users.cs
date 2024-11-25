using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public class Users : IdentityUser<Guid>
    {
        public string FullName { get; set; }
        public string? AliasName { get; set; }
        public string? PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
    }
}
