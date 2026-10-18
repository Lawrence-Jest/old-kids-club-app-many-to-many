using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsClubApp.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "a6b1931e-a519-45cc-9124-174566883005",
                    UserId = "723f57f2-4191-4383-9b24-2a8c0c181873"
                },

                new IdentityUserRole<string>
                {
                    RoleId = "30b65ab1-4f28-437f-8c2d-013a5ee87863",
                    UserId = "67fee137-8980-4cce-9b4e-935c2d36974d"
                }
                );

        }
    }
}
