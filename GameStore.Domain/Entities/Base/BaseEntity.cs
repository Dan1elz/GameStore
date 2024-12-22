using System.ComponentModel.DataAnnotations;

namespace GameStore.Domain.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; private init; } 
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public bool IsDeleted { get; private set; }

        public BaseEntity()
        {
            this.Id = Guid.NewGuid();
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.IsDeleted = false;
        }
        public void Update()
        {
            this.UpdatedAt = DateTime.Now;
        }

        public void Delete()
        {
            this.UpdatedAt = DateTime.Now;
            this.IsDeleted = true;
        }
    }
}
