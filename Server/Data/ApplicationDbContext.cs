using IdentityServer4.EntityFramework.Options;
using KidsClubApp.Server.Configurations.Entities;
using KidsClubApp.Server.Models;
using KidsClubApp.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsClubApp.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<SignInSheetEntry> SignInSheetEntry { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AddressSeedConfiguration());
            builder.ApplyConfiguration(new ParentSeedConfiguration());
            builder.ApplyConfiguration(new ChildSeedConfiguration());
            builder.ApplyConfiguration(new SignInSheetEntrySeedConfiguration());
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());

            //builder.Entity<Parent>()
            //    .HasMany(p => p.Children)
            //    .WithMany(p => p.Parents)
            //    .UsingEntity(j => j.HasData(new { ParentsParentId = 1, ChildrenChildId = 1 }));
        }
    }
}
