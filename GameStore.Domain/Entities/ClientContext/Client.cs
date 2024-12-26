using GameStore.Domain.DTOs.ClientContext.Client;
using GameStore.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Domain.Entities.ClientContext
{
    public class Client : BaseEntity
    {
        [MaxLength(100, ErrorMessage = "Name must have at most 100 characters"), Required(ErrorMessage = "Inform the name of the client")]
        public string Name { get; private set; } = string.Empty;

        [MaxLength(100, ErrorMessage = "Last name must have at most 100 characters"), Required(ErrorMessage = "Inform the last name of the client")]
        public string LastName { get; private set; } = string.Empty;

        [MaxLength(255, ErrorMessage = "Email must have at most 255 characters"), Required(ErrorMessage = "Inform the email of the client")]
        public string Email { get; private set; } = string.Empty;

        [MaxLength(32), MinLength(8, ErrorMessage = "Password must have at least 8 characters"), Required(ErrorMessage = "Inform the password of the client")]
        public string Password { get; private set; } = string.Empty;

        public DateOnly BirthDate { get; private init; }

        [MaxLength(11), MinLength(11, ErrorMessage = "CPF must have 11 characters"), Required(ErrorMessage = "Inform the CPF of the client")]
        public string CPF { get; private init; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }

        private Client() : base() { }
        public Client(CreateClientDTO client) : base()
        {
            Name = client.Name;
            LastName = client.LastName;
            Email = client.Email;
            Password = client.Password;
            BirthDate = client.BirthDate;
            CPF = client.CPF;
        }
        public void Update(UpdateClientDTO client)
        {
            Name = client.Name;
            LastName = client.LastName;
            base.Update();
        }
    }
}