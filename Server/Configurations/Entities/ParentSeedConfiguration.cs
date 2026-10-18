using KidsClubApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsClubApp.Server.Configurations.Entities
{
    public class ParentSeedConfiguration : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
        {
            builder.HasData(
                new Parent
                {
                    ParentId = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    FirstName = "Ernest",
                    LastName = "Doe",
                    HomePhoneNumber = "123-4567",
                    HomePhoneAreaCode = "604",
                    WorkPhoneNumber = "123-4567",
                    WorkPhoneAreaCode = "604",
                    CellPhoneNumber = "123-4567",
                    CellPhoneAreaCode = "604",
                    Email = "erniedoe@gmail.com",
                    AddressId = 1,
                    Children = new List<Child>(),// see if i can add child entrys here

                },
                  new Parent
                  {
                      ParentId = 2,
                      CreatedBy = "System",
                      DateCreated = DateTime.Now,
                      DateUpdated = DateTime.Now,
                      UpdatedBy = "System",
                      FirstName = "Valerie",
                      LastName = "Doe",
                      HomePhoneNumber = "123-4567",
                      HomePhoneAreaCode = "604",
                      WorkPhoneNumber = "123-4567",
                      WorkPhoneAreaCode = "604",
                      CellPhoneNumber = "123-4567",
                      CellPhoneAreaCode = "604",
                      Email = "valeriedoe@gmail.com",
                      AddressId = 1,
                      Children = new List<Child>(),// see if i can add child entrys here

                  }

                ) ;
        }
    }
}
