using KidsClubApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsClubApp.Server.Configurations.Entities
{
    public class SignInSheetEntrySeedConfiguration : IEntityTypeConfiguration<SignInSheetEntry>
    {
    
      
        public void Configure(EntityTypeBuilder<SignInSheetEntry> builder)
        {
            builder.HasData(
               new SignInSheetEntry
               {
                   SignInSheetEntryId = 1,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   UpdatedBy = "System",
                   ChildId = 1,
                   SignInTime = DateTime.Now,
                   SignOutTime = DateTime.Now,
                   IsSignedIn = false

               });
        }
    }
}
