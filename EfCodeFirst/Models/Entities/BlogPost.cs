using EfCodeFirst.Models.Common;

namespace EfCodeFirst.Models.Entities
{
    public class BlogPost: AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Body { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public int PublishedBy { get; set; }
        public DateTime PublishedAt { get; set;}
    }
}
