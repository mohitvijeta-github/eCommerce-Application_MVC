using Microsoft.EntityFrameworkCore;

namespace eCommerce_Application.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
    }
}
