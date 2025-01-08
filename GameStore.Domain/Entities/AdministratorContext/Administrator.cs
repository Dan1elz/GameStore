using GameStore.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Domain.Entities.AdministratorContext
{
    public class Administrator : BaseEntity
    {
        [MaxLength(100, ErrorMessage = "Name must have at most 100 characters"), Required(ErrorMessage = "Inform the name of the client")]
        public string Name { get; private set; } = string.Empty;

        [MaxLength(255, ErrorMessage = "Email must have at most 255 characters"), Required(ErrorMessage = "Inform the email of the client")]
        public string Email { get; private set; } = string.Empty;

        [MaxLength(32), MinLength(8, ErrorMessage = "Password must have at least 8 characters"), Required(ErrorMessage = "Inform the password of the client")]
        public string Password { get; private set; } = string.Empty;

        private Administrator() : base() { }

        public Administrator(string name, string email, string password) : base()
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
