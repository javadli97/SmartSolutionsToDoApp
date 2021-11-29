using Microsoft.AspNetCore.Identity;

namespace SmartSolutionsToDoApp.Domain
{
    public class Role : IdentityRole<int>
    {
        public Role()
        {
        }

        public Role(string roleName) : this()
        {
            Name = roleName;
        }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

    }
}
