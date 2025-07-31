using System;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Models
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
