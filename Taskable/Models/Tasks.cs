using System;
namespace Taskable.Models
{
    public class Tasks
    {
        public int TaskID { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
