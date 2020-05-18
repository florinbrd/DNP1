using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Model
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
            
        }
        
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}