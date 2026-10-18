using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClubApp.Shared.Domain
{
    public class Address : BaseDomainModel
    {
        public int AddressId { get; set; }
        public string HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string GreaterAddressArea { get; set; }//province,state,prefecture
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}
