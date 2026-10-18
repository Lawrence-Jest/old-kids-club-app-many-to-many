using KidsClubApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsClubApp.Server.Configurations.Entities
{
    public class ChildSeedConfiguration : IEntityTypeConfiguration<Child>
    {
        public void Configure(EntityTypeBuilder<Child> builder)
        {
            builder.HasData(
                new Child
                {
                    ChildId = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    FirstName = "John",
                    LastName = "Doe",
                    Birthday = new DateTime(2015, 9,1),
                    IsFileUpToDate = true,
                    AllowedOnSpontaneousTrips = true,
                    HasAllergies = false,
                    Allergies = "None",
                    Grade = "2",
                    //AddressId = 1


                },
                 new Child
                 {
                     ChildId = 2,
                     CreatedBy = "System",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     UpdatedBy = "System",
                     FirstName = "Jane",
                     LastName = "Doe",
                     Birthday = new DateTime(2017, 9, 1),
                     IsFileUpToDate = true,
                     AllowedOnSpontaneousTrips = true,
                     HasAllergies = false,
                     Allergies = "None",
                     Grade = "K",
                    // AddressId = 1


                 }

                );
        }
    }
}
