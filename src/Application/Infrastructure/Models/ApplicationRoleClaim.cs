using System;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Models
{
    public class ApplicationRoleClaim : IdentityRoleClaim<Guid>
    {
        public string Description { get; set; }
        public string Group { get; set; }
    }
}
