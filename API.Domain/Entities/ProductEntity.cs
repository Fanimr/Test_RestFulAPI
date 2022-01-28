
namespace API.Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Category { get; set; }
        public float Price { get; set; }
        public int Amount { get; set; }
    }
}
