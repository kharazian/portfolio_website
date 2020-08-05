using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace AKH.Portfolio.Blog
{
    public class CreateUpdatePostDto
    {
        public string ImageBy { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string ImageLink { get; set; }
        public string Published { get; set; }
        public string Subtitle { get; set; }
        [Required]
        [StringLength(128)]
        public string Title { get; set; }
        public string Category { get; set; }
    }
}