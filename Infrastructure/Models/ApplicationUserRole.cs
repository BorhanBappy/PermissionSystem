using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Models;

public class ApplicationUserRole : IdentityUserRole<Guid>
{
    public ApplicationUser User { get; set; }
    public ApplicationRole Role { get; set; }
}