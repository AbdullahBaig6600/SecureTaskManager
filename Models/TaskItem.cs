namespace SecureTaskManager.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Data.Enums.TaskStatus Status { get; set; }

        // Foreign Key
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
