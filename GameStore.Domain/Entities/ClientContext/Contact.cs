using System.ComponentModel.DataAnnotations.Schema;
using GameStore.Domain.DTOs.ClientContext.Contact;
using System.ComponentModel.DataAnnotations;
using GameStore.Domain.Entities.Base;

namespace GameStore.Domain.Entities.ClientContext
{
    public class Contact : BaseEntity
    {
        [ForeignKey("Client"), Required]
        public Guid ClientId { get; private init; }
        public virtual Client Client { get; set; }
        [MaxLength(255, ErrorMessage = "Description must have at most 255 characters"), Required]
        public string Description { get; private set; } = string.Empty;
        [MaxLength(15, ErrorMessage = "Phone Number must have at most 15 characters"), Required]
        public string PhoneNumber { get; private set; } = string.Empty;
        [MaxLength(255, ErrorMessage = "Email must have at most 255 characters"), Required]
        public string Email { get; private set; } = string.Empty;
        public Contact() : base() { }
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