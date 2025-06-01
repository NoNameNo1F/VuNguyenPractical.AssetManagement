using System.Security.Claims;

namespace AssetManagement.WebAPI.Utils;

internal static class ClaimsPrincipalUtil
{
    internal static string GetUserId(this ClaimsPrincipal claims)
    {
        var claim = claims.FindFirst(ClaimTypes.NameIdentifier);
        if (claim is null)
        {
            throw new UnauthorizedAccessException();
        }
        
        return claim.Value;
    }
}