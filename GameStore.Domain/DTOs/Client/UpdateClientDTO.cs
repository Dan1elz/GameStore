using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Domain.DTOs.Client
{
    public record UpdateClientDTO(string Name, string LastName);
}