namespace EfCodeFirst.Models.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public int ProductId { get; set; }
    }
}
