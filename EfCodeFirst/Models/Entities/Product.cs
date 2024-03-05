using EfCodeFirst.Models.Common;

namespace EfCodeFirst.Models.Entities
{
    public class Product : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string StockKeepingUnit { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
    }
}
