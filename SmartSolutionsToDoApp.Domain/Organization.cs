using System;
using System.Collections.Generic;

namespace SmartSolutionsToDoApp.Domain
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public ICollection<AppUser> Users { get; set; }
    }
}
