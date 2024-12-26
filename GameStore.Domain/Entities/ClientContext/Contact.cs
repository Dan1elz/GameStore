using GameStore.Domain.DTOs.ClientContext.Contact;
using GameStore.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Domain.Entities.ClientContext
{
    public class Contact : BaseEntity
    {
        [ForeignKey("Client"), Required(ErrorMessage = "Pleace enter the Client ID")]
        public Guid ClientId { get; private init; }
        public virtual Client Client { get; private set; }

        [MaxLength(255, ErrorMessage = "Description must have at most 255 characters"), Required(ErrorMessage = "Inform the Description of Client")]
        public string Description { get; private set; } = string.Empty;

        [MaxLength(15, ErrorMessage = "Phone Number must have at most 15 characters"), Required(ErrorMessage = "Inform the Phone of Client")]
        public string PhoneNumber { get; private set; } = string.Empty;

        [MaxLength(255, ErrorMessage = "Email must have at most 255 characters"), Required(ErrorMessage = "Inform the Email of Client")]
        public string Email { get; private set; } = string.Empty;

        private Contact() : base() { }

        public Contact(CreateContactDTO contact) : base()
        {
            ClientId = contact.Client.Id;
            Client = contact.Client;
            Description = contact.Description;
            PhoneNumber = contact.PhoneNumber;
            Email = contact.Email;
        }
        public void Update(UpdateContactDTO contact)
        {
            Description = contact.Description;
            PhoneNumber = contact.PhoneNumber;
            Email = contact.Email;
            base.Update();
        }
    }
}