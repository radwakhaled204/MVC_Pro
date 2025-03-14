using System.ComponentModel.DataAnnotations;

namespace Mvc_train.Models
{
    public class mvcCategory
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="")]
        public string? Name { get; set; }
        public ICollection<Item>? Items { get; set; }
    }
}
