using EfCodeFirst.Models.Common;

namespace EfCodeFirst.Models.Entities
{
    public class Category: AuditableEntity
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
      

        // Navigation properties
        //public Category ParentCategory { get; set; }
        //public ICollection<Category> SubCategories { get; set; }
    }
}
