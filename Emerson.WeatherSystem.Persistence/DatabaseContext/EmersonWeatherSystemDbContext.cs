using Emerson.WeatherSystem.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM.APCM.Apparel.Persistence.DatabaseContext;

public class EmersonWeatherSystemDbContext: DbContext
{
    public EmersonWeatherSystemDbContext(DbContextOptions<EmersonWeatherSystemDbContext> options) : base(options)
    {        
    }

    public DbSet<City> Cities { get; set; }    
    public DbSet<Variable> Variables { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmersonWeatherSystemDbContext).Assembly);
        modelBuilder.Entity<City>().ToTable("City");
        modelBuilder.Entity<Variable>().ToTable("Variable");
        base.OnModelCreating(modelBuilder);
    }

    /*
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in base.ChangeTracker.Entries<BaseDomainEntity>()
            .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
        {
            entry.Entity.ModifiedDate = DateTime.Now;

            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedDate = DateTime.Now;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
    */
}
