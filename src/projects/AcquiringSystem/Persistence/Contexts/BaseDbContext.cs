using Core.Security.Entities;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Persistence.Contexts
{
    public class BaseDbContext:DbContext
    {
        protected IConfiguration Configuration { get; set; }

        public DbSet<Chain> Chains { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<EmailAuthenticator> EmailAuthenticators { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<OtpAuthenticator> OtpAuthenticators { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            /*Database.EnsureCreated() bir Entity Framework Core yöntemidir. Bu yöntem, var olan bir veritabanı yoksa bir veritabanı oluşturur. Veritabanı modelini kullanan bir DbContext sınıfında çağrıldığında, Entity Framework Core otomatik olarak veritabanının var olup olmadığını kontrol eder ve var olmadığında veritabanını oluşturur.  */

            Configuration = configuration;

            // EN ÖNEMLİ KISIMDI
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
