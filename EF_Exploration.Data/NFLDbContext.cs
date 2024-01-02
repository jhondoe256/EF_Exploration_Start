using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EF_Exploration.Data
{
    public class NFLDbContext : DbContext
    {
        public NFLDbContext() { }

        //! We are settnig this up for demo purposes only!!!!
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //! We are settnig this up for demo purposes only!!!!
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder
            .UseSqlServer("Server=127.0.0.1;Database=NFL_EF_Exploration;User Id=SA;Password=;Trust Server Certificate=true;")
            .LogTo(Console.WriteLine, LogLevel.Information) // we want the console to log out all of the information
            .EnableSensitiveDataLogging() //Eduational usage only can show things that need to be hidden
            .EnableDetailedErrors(); //Eduational usage only
        }

    }
}