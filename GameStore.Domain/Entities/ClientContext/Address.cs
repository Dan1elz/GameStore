using System.ComponentModel.DataAnnotations.Schema;
using GameStore.Domain.DTOs.ClientContext.Address;
using System.ComponentModel.DataAnnotations;
using GameStore.Domain.Entities.Base;

namespace GameStore.Domain.Entities.ClientContext
{
    public class Address : BaseEntity
    {
        [ForeignKey("Client"), Required(ErrorMessage = "Please enter the client ID")]
        public Guid ClientId { get; private init; }
        public virtual Client Client { get; set; }

        /// <summary>
        /// Descrição
        /// </summary>
        [MaxLength(255, ErrorMessage = "Description must have at most 255 characters"), Required(ErrorMessage = "Inform the Description of Client")]
        public string Description { get; private set; } = string.Empty;

        /// <summary>
        /// Rua
        /// </summary>
        [MaxLength(100, ErrorMessage = "Street must have at most 100 characters"), Required(ErrorMessage = "Inform the Street of Client")]
        public string Street { get; private set; } = string.Empty;

        /// <summary>
        /// Número
        /// </summary>
        [MaxLength(10, ErrorMessage = "Number must have at most 10 characters"), Required(ErrorMessage = "Inform the Number of Client")]
        public string Number { get; private set; } = string.Empty;

        /// <summary>
        /// Bairro
        /// </summary>
        [MaxLength(100, ErrorMessage = "District must have at most 100 characters"), Required(ErrorMessage = "Inform the District of Client")]

        public string District { get; private set; } = string.Empty;

        /// <summary>
        /// Cidade
        /// </summary>
        [MaxLength(100, ErrorMessage = "City must have at most 100 characters"), Required(ErrorMessage = "Inform the City of Client")]
        public string City { get; private set; } = string.Empty;

        /// <summary>
        /// Estado
        /// </summary>
        [MaxLength(2, ErrorMessage = "State must have at most 2 characters"), Required(ErrorMessage = "Inform the State of Client")]
        public string State { get; private set; } = string.Empty;

        /// <summary>
        /// Complemento
        /// </summary>
        [MaxLength(100, ErrorMessage = "Complement must have at most 100 characters"), Required(ErrorMessage = "Inform the Complement of Client")]
        public string Complement { get; private set; } = string.Empty;

        /// <summary>
        /// CEP
        /// </summary>
        [MaxLength(8, ErrorMessage = "Zip code must have at most 8 characters"), Required(ErrorMessage = "Inform the Zip Code of Client")]

        public string ZipCode { get; private set; } = string.Empty;
        private Address() : base() { }
        public Address(CreateAddresDTO address) : base()
        {
            ClientId = address.Client.Id;
            Client = address.Client;
            Street = address.Street;
            Number = address.Number;
            District = address.District;
            City = address.City;
            State = address.State;
            ZipCode = address.ZipCode;
        }
        public void Update(UpdateAddressDTO address)
        {
            Street = address.Street;
            Number = address.Number;
            District = address.District;
            City = address.City;
            State = address.State;
            ZipCode = address.ZipCode;
            base.Update();
        }
    }
}