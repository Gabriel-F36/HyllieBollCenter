using System.Security.Claims;

namespace HyllieBollCenter
{
    public static class ClaimsPricipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
