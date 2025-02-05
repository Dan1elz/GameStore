﻿using GameStore.Domain.DTOs.InteractionContext.Inventory;
using GameStore.Domain.Entities.Base;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Domain.Entities.InteractionContext
{
    public class Inventory : BaseEntity
    {
        [ForeignKey("Client"), Required(ErrorMessage = "Please enter the Client ID")]
        public Guid ClientId { get; private init; }
        public virtual Client Client { get; private init; }

        [ForeignKey("Product"), Required(ErrorMessage = "Please enter the product ID")]
        public Guid ProductId { get; private init; }
        public virtual Product Product { get; private init; }

        [Required(ErrorMessage = "Please enter the Access")]
        public string Access { get; private init; }
        [Required(ErrorMessage = "Please enter the Method Access")]
        public MethodAccess MethodAccess { get; private init; }

        private Inventory() : base() { }
        public Inventory(CreateInventoryDTO inventory) : base()
        {
            ClientId = inventory.Client.Id;
            Client = inventory.Client;
            ProductId = inventory.Product.Id;
            Product = inventory.Product;
            Access = inventory.Access;
            MethodAccess = inventory.MethodAccess;
        }

    }
}
