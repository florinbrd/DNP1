using System.ComponentModel.DataAnnotations;

namespace WebApplication.Model
{
    public class TodoItem
    {
        public long Id { get; set; }
        
        [MinLength(3)]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isCompleted { get; set; }
    }
}