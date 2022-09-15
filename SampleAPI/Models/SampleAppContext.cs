using Microsoft.EntityFrameworkCore;

namespace SampleAPI.Models
{
    public class SampleAppContext : DbContext
    {
        public SampleAppContext(DbContextOptions<SampleAppContext> options) : base(options) {}

        public DbSet<Person> People { get; set; } = null!;
    }
}