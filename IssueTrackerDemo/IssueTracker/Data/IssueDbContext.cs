using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Data
{
    public class IssueDbContext : DbContext
    {
        // This constructor with two parameters will help configure the db context for dependency injection.

        public IssueDbContext(DbContextOptions options):base(options)
        {

        }
    }
}
