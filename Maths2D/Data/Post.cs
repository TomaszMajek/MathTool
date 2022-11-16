using System.ComponentModel.DataAnnotations;

namespace Maths2D.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = "";
        [Required]
        public string Body { get; set; } = "";
        public string? Created { get; set; }
        [Required]
        public string Description { get; set; } = "";
    }
}
