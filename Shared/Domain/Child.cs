using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClubApp.Shared.Domain
{
    public  class Child : BaseDomainModel
    {
        public int ChildId { get; set; }
        //public int AddressId { get; set; }
        //public virtual Address Address { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }      
        public DateTime Birthday { get; set; }
        public bool IsFileUpToDate { get; set; }
        public bool AllowedOnSpontaneousTrips { get; set; }
        public bool HasAllergies { get; set; }
        public string Allergies { get; set; }
        public string Grade { get; set; }
        //public virtual List<Parent> Parents { get; set; }
    }
}
