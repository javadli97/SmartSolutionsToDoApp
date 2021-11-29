using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace SmartSolutionsToDoApp.Application.Core
{
    public class CurrentUserService : ICurrentUserService
    {
        public int UserId
        {
            get
            {
                return GetUserId();
            }
        }

        public ClaimsIdentity UserIdentity
        {
            get
            {
                return GetUserIdentity();
            }
        }

        public bool HasClaim(string claimName)
        {
            return GetUserIdentity().Claims.Any(x => x.Type == claimName);
        }

        public Claim GetUserClaim(string claimType)
        {
            var result = GetUserIdentity();

            return result.Claims.FirstOrDefault(x => x.Type == claimType);
        }

        public string GetUserClaimValue(string claimName)
        {
            var result = GetUserIdentity().Claims.FirstOrDefault(x => x.Type == claimName);

            if (result != null)
            {
                return result?.Value;
            }

            return "";
        }

        public IEnumerable<Claim> GetUserClaims()
        {
            var result = GetUserIdentity();

            return result.Claims;
        }

        private ClaimsIdentity GetUserIdentity()
        {
            return (ClaimsIdentity)new HttpContextAccessor().HttpContext.User.Identity;
        }

        private int GetUserId()
        {
            var result = GetUserIdentity().FindFirst(ClaimTypes.NameIdentifier)?.Value;

            return Convert.ToInt32(result);
        }
    }
}
