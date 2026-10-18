using KidsClubApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsClubApp.Server.Configurations.Entities
{
    public class AddressSeedConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasData(
               new Address
               {
                   AddressId = 1,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   UpdatedBy = "System",
                   HouseNumber = "2725",
                   StreetName = "Woodbine Drive",
                   City = "North Vancouver",
                   GreaterAddressArea = "BC",
                   Country = "Canada",
                   PostalCode = "V7R 2R7"
               },
               new Address
               {
                   AddressId = 2,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   UpdatedBy = "System",
                   HouseNumber = "1320",
                   StreetName = "East 18th Street",
                   City = "North Vancouver",
                   GreaterAddressArea = "BC",
                   Country = "Canada",
                   PostalCode = "V7M 1J2"
               }

               );
        }
    }
}
