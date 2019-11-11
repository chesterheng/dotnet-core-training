using Microsoft.EntityFrameworkCore;
using MvcTodo.Models;

namespace MvcTodo.Data
{
    public class MvcTodoContext: DbContext
    {
        public MvcTodoContext(DbContextOptions<MvcTodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItem { get; set; }
    }
}
