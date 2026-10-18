using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClubApp.Shared.Domain
{
    public class Parent : BaseDomainModel
    {
        public int ParentId { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }       
        public string HomePhoneAreaCode { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneAreaCode { get; set; }
        public string CellPhoneNumber { get; set; }
        public string WorkPhoneAreaCode { get; set; }
        public string WorkPhoneNumber { get; set; }
        public string Email { get; set; }
        public virtual List<Child> Children { get; set; }




    }
}
