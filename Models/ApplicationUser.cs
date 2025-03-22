using Microsoft.AspNetCore.Identity;

namespace SecureTaskManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
