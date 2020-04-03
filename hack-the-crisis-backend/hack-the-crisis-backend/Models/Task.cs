using System;
namespace hack_the_crisis_backend.Models
{
    public class Task
    {
        public long TaskId { get; set; }
        public long CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public string OwnerId { get; set; }
        public string AssigneeId { get; set; }
        public string PaymentDetails { get; set; }
        public int Price { get; set; }
    }
}
