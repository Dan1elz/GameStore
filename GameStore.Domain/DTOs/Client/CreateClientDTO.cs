using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Domain.DTOs.Client
{
  public record CreateClientDTO(string Name, string LastName, string Email, string Password, Date BirthDate, string CPF);
}