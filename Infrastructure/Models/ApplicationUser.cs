using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Models;

public class ApplicationUser:IdentityUser<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
    public bool IsActive { get; set; }
}


