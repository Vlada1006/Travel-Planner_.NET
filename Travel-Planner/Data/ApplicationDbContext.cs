using Microsoft.EntityFrameworkCore;

namespace Travel_Planner.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }


    }
}
