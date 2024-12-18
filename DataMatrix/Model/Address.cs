using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMatrix.Model
{
    public record Address
    {
        public Address()
        {
        }

        public required int Id { get; set; }
        public required string AddressLine1 { get; set; }
        public required string AddressLine2 { get; set; }

        
    }
    //public record Address(int id, string addressLine1, string addressLine2);
}
