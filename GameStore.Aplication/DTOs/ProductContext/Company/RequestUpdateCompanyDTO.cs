using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Aplication.DTOs.ProductContext.Company
{
    public record RequestUpdateCompanyDTO(string Name, string CNPJ, string? Email);
}
