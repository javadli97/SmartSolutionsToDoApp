using SmartSolutionsToDoApp.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartSolutionsToDoApp.Domain
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Deadline { get; set; }
        public TaskStatus Status { get; set; }

        public ICollection<UsersTasks> UserTasks { get; set; } = new List<UsersTasks>();



    }
}
