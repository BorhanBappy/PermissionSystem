using System.Collections.ObjectModel;
using Common.Authoriazation;

namespace Common.Authorization;

public record AppPermission(
    string Feature,
    string Action,
    string Group,
    string Description,
    bool IsBasic = false)
{
    public string Name { get; set; }

    public static string NameFor(string feature, string action)
    {
        return $"Permission.{feature}.{action}";
    }

    public class AppPermissions
    {
        private static readonly AppPermission[] _all = new AppPermission[]
        {
            new(AppFeature.Users, AppAction.Create, AppRoleGroup.SystemAccess, "Create User"),
            new(AppFeature.Users, AppAction.Read, AppRoleGroup.SystemAccess, "View User"),
            new(AppFeature.Users, AppAction.Update, AppRoleGroup.SystemAccess, "Update User"),
            new(AppFeature.Users, AppAction.Delete, AppRoleGroup.SystemAccess, "Delete User"),

            new(AppFeature.UserRoles, AppAction.Read, AppRoleGroup.SystemAccess, "View Role"),
            new(AppFeature.UserRoles, AppAction.Update, AppRoleGroup.SystemAccess, "Update Role"),

            new(AppFeature.Roles, AppAction.Create, AppRoleGroup.SystemAccess, "Create Role"),
            new(AppFeature.Roles, AppAction.Read, AppRoleGroup.SystemAccess, "View Role"),
            new(AppFeature.Roles, AppAction.Update, AppRoleGroup.SystemAccess, "Update Role"),
            new(AppFeature.Roles, AppAction.Delete, AppRoleGroup.SystemAccess, "Delete Role"),

            new(AppFeature.RoleClaim, AppAction.Read, AppRoleGroup.SystemAccess,
                "View Role Claims/Permissions"),
            new(AppFeature.RoleClaim, AppAction.Update, AppRoleGroup.SystemAccess,
                "Update Role Claims/Permissions"),

            new(AppFeature.Employees, AppAction.Create, AppRoleGroup.SystemAccess,
                "Create Employee"),
            new(AppFeature.Employees, AppAction.Read, AppRoleGroup.SystemAccess,
                "View Employee Details", true),
            new(AppFeature.Employees, AppAction.Update, AppRoleGroup.SystemAccess,
                "Update Employee"),
            new(AppFeature.Employees, AppAction.Delete, AppRoleGroup.SystemAccess,
                "Delete Employee"),
        };

        public static IReadOnlyList<AppPermission> Admin { get; } =
            new ReadOnlyCollection<AppPermission>(_all.Where(p => !p.IsBasic).ToArray());
        public static IReadOnlyList<AppPermission> BasicPermissions { get; } = new ReadOnlyCollection<AppPermission>(
            _all.Where(p => p.IsBasic).ToArray());
    }
}