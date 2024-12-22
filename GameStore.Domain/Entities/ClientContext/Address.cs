using GameStore.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GameStore.Domain.DTOs.Address;

namespace GameStore.Domain.Entities.ClientContext
{
    public class Address : BaseEntity
    {

        [ForeignKey("Client"), Required]
        public Guid ClientId { get; private set; }
        public Client Client { get; set; }

        /// <summary>
        /// Descrição
        /// </summary>
        [MaxLength(255, ErrorMessage = "Description must have at most 255 characters"), Required]
        public string Description { get; private set; } = string.Empty;

        /// <summary>
        /// Rua
        /// </summary>
        [MaxLength(100, ErrorMessage = "Street must have at most 100 characters"), Required]
        public string Street { get; private set; } = string.Empty;

        /// <summary>
        /// Número
        /// </summary>
        [MaxLength(10, ErrorMessage = "Number must have at most 10 characters"), Required]
        public string Number { get; private set; } = string.Empty;
        
        /// <summary>
        /// Bairro
        /// </summary>
        [MaxLength(100, ErrorMessage = "District must have at most 100 characters"), Required]
        public string District { get; private set; } = string.Empty;
        
        /// <summary>
        /// Cidade
        /// </summary>
        [MaxLength(100, ErrorMessage = "City must have at most 100 characters"), Required]
        public string City { get; private set; } = string.Empty;

        /// <summary>
        /// Estado
        /// </summary>
        [MaxLength(2, ErrorMessage = "State must have at most 2 characters"), Required]
        public string State { get; private set; } = string.Empty;

        /// <summary>
        /// Complemento
        /// </summary>
        [MaxLength(100, ErrorMessage = "Complement must have at most 100 characters"), Required]
        public string Complement { get; private set; } = string.Empty;

        /// <summary>
        /// CEP
        /// </summary>
        [MaxLength(8, ErrorMessage = "Zip code must have at most 8 characters"), Required]
        public string ZipCode { get; private set; } = string.Empty;

        public Address() : base()
        {}

        public Address(CreateAddresDTO address) : base()
        {
            this.ClientId = address.Client.Id;
            this.Client = address.Client;
            this.Street = address.Street;
            this.Number = address.Number;
            this.District = address.District;
            this.City = address.City;
            this.State = address.State;
            this.ZipCode = address.ZipCode;
        }
        public void Update(UpdateAddressDTO address)
        {
            this.Street = address.Street;
            this.Number = address.Number;
            this.District = address.District;
            this.City = address.City;
            this.State = address.State;
            this.ZipCode = address.ZipCode;
            base.Update();
        }

    }
}