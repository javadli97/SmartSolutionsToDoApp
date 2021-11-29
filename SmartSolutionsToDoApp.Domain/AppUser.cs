using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SmartSolutionsToDoApp.Domain
{
    public class AppUser : IdentityUser<int>
    {
        public int OrganizationId { get; set; }

        public Organization Organization { get; set; }
        public ICollection<UsersTasks> UserTasks { get; set; }


    }
}
