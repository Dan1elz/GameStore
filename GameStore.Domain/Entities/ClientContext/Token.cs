using System.ComponentModel.DataAnnotations.Schema;
using GameStore.Domain.DTOs.ClientContext.Token;
using System.ComponentModel.DataAnnotations;
using GameStore.Domain.Entities.Base;

namespace GameStore.Domain.Entities.ClientContext
{
    public class Token : BaseEntity
    {
        [ForeignKey("Client"), Required(ErrorMessage = "Please enter the client ID")]
        public Guid ClientId { get; private init; }
        public virtual Client Client { get; set; }
        
        public string Value { get; private init; }
        
        private Token() : base() { }
        public Token(CreateTokenDTO token) : base()
        {
            ClientId = token.Client.Id;
            Client = token.Client;
            Value = token.Value;
        }
    }
}