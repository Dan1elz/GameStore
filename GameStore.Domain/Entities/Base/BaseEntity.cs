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

        protected BaseEntity()
        {
            this.Id = Guid.NewGuid();
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.IsDeleted = false;
        }
        protected void Update()
        {
            this.UpdatedAt = DateTime.Now;
        }

        protected void Delete()
        {
            this.UpdatedAt = DateTime.Now;
            this.IsDeleted = true;
        }
    }
}
