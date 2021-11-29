using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartSolutionsToDoApp.Domain;

namespace SmartSolutionsToDoApp.Persistence.Configurations.UserTasks
{
    public class UserTasksConfiguration : IEntityTypeConfiguration<UsersTasks>
    {
        public void Configure(EntityTypeBuilder<UsersTasks> builder)
        {
            builder.HasOne(a => a.Task)
                           .WithMany(f => f.UserTasks)
                           .HasForeignKey(a => a.TaskId);

            builder.HasOne(a => a.User)
                .WithMany(f => f.UserTasks)
                .HasForeignKey(a => a.UserId);
        }
    }
}
