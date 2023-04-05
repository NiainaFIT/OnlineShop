using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OnlineShop.Server.Models;

namespace OnlineShop.Server.Data
{
    public class ApplicationDbContext : KeyApiAuthorizationDbContext<User, Role, int>
    {
        public ApplicationDbContext(
        DbContextOptions options,
        IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity => { entity.ToTable(name: "User"); });
            modelBuilder.Entity<Role>(entity => { entity.ToTable(name: "Role"); });
        }
    }
}