using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteContext = GameStore.Domain.Entities.ClientContext;

namespace GameStore.Domain.DTOs.Address
{
    public record CreateAddresDTO(ClienteContext.Client Client, string Street, string Number, string District, string City, string State, string ZipCode);
}