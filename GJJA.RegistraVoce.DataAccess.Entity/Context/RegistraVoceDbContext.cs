using GJJA.RegistraVoce.Domain;
using Microsoft.EntityFrameworkCore;

namespace GJJA.ResgistraVoce.DataAccess.Entity.Context
{
    public class RegistraVoceDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        
        public RegistraVoceDbContext(DbContextOptions options) 
           : base(options)
        {
            
        }

    }

}