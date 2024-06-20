using IdentityModel;
using Microsoft.AspNetCore.Http;
using MovieManagement.Application.Common.Interfaces;
using System.Security.Claims;

namespace MovieManagement.Api.Service
{
    public class CurrentUserService : ICurrentUserService
    {
        public string Email { get; set; }
        public bool IsAuthenticated { get; set; }
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            var email = httpContextAccessor.HttpContext?.User?.FindFirstValue(JwtClaimTypes.Email);

            Email = email;

            IsAuthenticated = !string.IsNullOrEmpty(email);
        }
    }
}
