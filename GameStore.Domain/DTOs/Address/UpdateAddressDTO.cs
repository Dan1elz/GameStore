using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.DTOs.Address
{
    public record UpdateAddressDTO( string Street, string Number, string District, string City, string State, string ZipCode);

}
