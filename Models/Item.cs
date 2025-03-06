using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_train.Models
{/// <summary>
/// 9
/// </summary>
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("The Price")]
        [Range(10 , 1000 , ErrorMessage = "value must between 10 and 1000")]
        public decimal Price {get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        [Required]
        [DisplayName("Category")]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        
        public mvcCategory? Category { get; set; }
    }
}
