using Covidapi.Models;
using Lucene.Net.Support;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Covidapi.Configuration
{
    public partial class AreaGeoContext : DbContext
    {
        public class DatabaseCxt : DbContext
        {
            public readonly string _connectionString;

            public DatabaseCxt(DbContextOptions<DatabaseCxt> opts, IOptions<AppSettings> setting) : base(opts)
            {
                _connectionString = setting.Value.ConnectionString;
            }
            public DatabaseCxt()
            {

            }
        }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            }

            public DbSet<Continent> Continent { get; set; }
            public DbSet<City> City { get; set; }
            public DbSet<Country> Country { get; set; }
        }
    }




