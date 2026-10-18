using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClubApp.Shared.Domain
{
    public class SignInSheetEntry : BaseDomainModel
    {
        public int SignInSheetEntryId { get; set; }
        public DateTime SignInTime { get; set; }
        public DateTime SignOutTime { get; set; }
        public int ChildId { get; set; }
        public Child Child { get; set; }
        public bool  IsSignedIn { get; set; }
        
    }
}
