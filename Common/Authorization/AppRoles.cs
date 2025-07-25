using System.Collections.ObjectModel;

namespace Common.Authorization;

public class AppRoles
{
    public const string Admin = nameof(Admin);
    public const string Basic = nameof(Basic);

    public static IReadOnlyList<string> DefaultRoles { get; } =
        new ReadOnlyCollection<string>(new[]
        {
            Admin,
            Basic
        });

    public static bool IsDefault(string roleName) => DefaultRoles.Any(x =>
        x == roleName);
} 