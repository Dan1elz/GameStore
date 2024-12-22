using GameStore.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using GameStore.Domain.DTOs.Client;

namespace GameStore.Domain.Entities.ClientContext
{
    public class Client : BaseEntity
    {
        [MaxLength(100, ErrorMessage = "Name must have at most 100 characters"), Required]
        public string Name { get; private set; } = string.Empty;
        [MaxLength(100, ErrorMessage = "Last name must have at most 100 characters"), Required]
        public string LastName { get; private set; } = string.Empty;
        [MaxLength(255, ErrorMessage = "Email must have at most 255 characters"), Required]
        public string Email { get; private set; } = string.Empty;
        [MaxLength(32), MinLength(8, ErrorMessage = "Password must have at least 8 characters"), Required]
        public string Password { get; private set; } = string.Empty;
        public DateOnly BirthDate { get; private init; }
        [MaxLength(11), MinLength(11, ErrorMessage = "CPF must have 11 characters"), Required]
        public string CPF { get; private init; }
        public ICollection<Address> Addresses { get; set; }

        public Client(CreateClientDTO client) : base()
        {
            this.Name = client.Name;
            this.LastName = client.LastName;
            this.Email = client.Email;
            this.Password = client.Password;
            this.BirthDate = client.BirthDate;
            this.CPF = client.CPF;
        }
        public void Update(UpdateClientDTO client)
        {
            this.Name = client.Name;
            this.LastName = client.LastName;
            base.Update();
        }
    }
}