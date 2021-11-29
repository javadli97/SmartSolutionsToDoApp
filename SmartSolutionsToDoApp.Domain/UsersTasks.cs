using System;

namespace SmartSolutionsToDoApp.Domain
{
    public class UsersTasks
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TaskId { get; set; }

        public AppUser User { get; set; }
        public Task Task { get; set; }
    }
}
