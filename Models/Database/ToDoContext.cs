using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models.Database
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions options) : base(options) {}

        public DbSet<User> Users {get; set; }

        public DbSet<Activity> Activities {get; set; }

        public DbSet<RSVP> RSVPs {get; set; }

    }
}