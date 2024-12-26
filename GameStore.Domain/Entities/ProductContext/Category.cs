using System.ComponentModel.DataAnnotations;
using GameStore.Domain.Entities.Base;

namespace GameStore.Domain.Entities.ProductContext
{
    public class Category : BaseEntity
    {
        [MaxLength(255, ErrorMessage = "Category description must have at most 255 characters"), Required(ErrorMessage = "Inform the description of the category")]
        public string Description { get; private set; } = string.Empty;

        private Category() : base() { }
        public Category(string description) : base()
        {
            Description = description;
        }
        public void Update(string description)
        {
            Description = description;
            base.Update();
        }
    }
}
