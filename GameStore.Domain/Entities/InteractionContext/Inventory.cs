using GameStore.Domain.DTOs.InteractionContext.Inventory;
using System.ComponentModel.DataAnnotations.Schema;
using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Entities.Base;
using GameStore.Domain.Enum;

using System.ComponentModel.DataAnnotations;

namespace GameStore.Domain.Entities.InteractionContext
{
    public class Inventory : BaseEntity
    {
        [ForeignKey("Client"), Required(ErrorMessage = "Please enter the Client ID")]
        public Guid ClientId { get; private init; }
        public virtual Client Client { get; set; }

        [ForeignKey("Product"), Required(ErrorMessage = "Please enter the product ID")]
        public Guid ProductId { get; private init; }
        public virtual Product Product { get; set; }

        [Required(ErrorMessage = "Please enter the Access")]
        public string Access { get; private init;}
        [Required(ErrorMessage = "Please enter the Method Access")]
        public MethodAccess MethodAccess { get; private init; }

        private Inventory() : base() { }
        public Inventory(CreateInventoryDTO inventory) : base()
        {
            ClientId = inventory.ClientId;
            ProductId = inventory.ProductId;
            Access = inventory.Access;
            MethodAccess = inventory.MethodAccess;
        }

    }
}
