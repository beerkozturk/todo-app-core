
using Microsoft.EntityFrameworkCore;
using todo_app_api.Models.Entities;

namespace CRUD_APP.Models
{
    public class ToDoDbContext : DbContext
    {

        public DbSet<ToDo> Tasks { get; set; }
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
    }
}

