using System.ComponentModel.DataAnnotations;

namespace Mvc_train.Models
{//45// 9
    public class mvcCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public ICollection<Item>? Items { get; set; }
    }
}
