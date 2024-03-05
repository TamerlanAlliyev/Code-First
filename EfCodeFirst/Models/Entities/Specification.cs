using EfCodeFirst.Models.Common;

namespace EfCodeFirst.Models.Entities
{
    public class Specification:AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
