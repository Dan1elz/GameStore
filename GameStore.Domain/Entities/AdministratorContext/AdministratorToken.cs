using GameStore.Domain.DTOs.AdministratorContext.Token;
using GameStore.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Domain.Entities.AdministratorContext
{
    public class AdministratorToken : BaseEntity
    {
        [ForeignKey("Administrator"), Required(ErrorMessage = "Please enter the Administrator ID")]
        public Guid AdministratorId { get; private init; }
        public virtual Administrator Administrator { get; private set; }

        public string Value { get; private init; }

        private AdministratorToken() : base() { }
        public AdministratorToken(CreateAdministratorTokenDTO token) : base()
        {
            AdministratorId = token.Administrator.Id;
            Administrator = token.Administrator;
            Value = token.Value;
        }
    }
}
