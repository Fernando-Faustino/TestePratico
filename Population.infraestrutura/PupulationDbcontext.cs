using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Population.infraestrutura
{
    public class PupulationDbcontext : DbContext 
    {
        private IConfiguration _configuration;

        public PupulationDbcontext(IConfiguration configuration, DbContextOptions options) : base(options)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var typeDatabase = _configuration["TypeDatabase"];
            var connectionString = _configuration.GetConnectionString(typeDatabase);

            if (typeDatabase == "SqlServer") {
                 optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
