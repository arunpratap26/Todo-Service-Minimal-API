using Microsoft.EntityFrameworkCore;

namespace TodoMinimalApi
{
    public class TodoDb(DbContextOptions<TodoDb> options) : DbContext(options)
    {
        public DbSet<TodoItem> Todos { get; set; }
    }
}
