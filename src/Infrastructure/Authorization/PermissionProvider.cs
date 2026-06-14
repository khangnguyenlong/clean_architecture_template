using Application.Abstractions.Caching;

namespace Infrastructure.Authorization;

internal sealed class PermissionProvider(ICacheService cacheService)
{
    public async Task<HashSet<string>> GetForUserIdAsync(Guid userId)
    {
        string cacheKey = $"auth:permissions-{userId}";
        HashSet<string>? cachedPermissions = await cacheService.GetAsync<HashSet<string>>(cacheKey);

        if (cachedPermissions is not null)
        {
            return cachedPermissions;
        }

        // TODO: Here you'll implement your logic to fetch permissions.
        HashSet<string> permissionsSet = [];

        await cacheService.SetAsync(cacheKey, permissionsSet);

        return permissionsSet;
    }
}
