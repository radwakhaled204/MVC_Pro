using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_train.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter The Name")]
        public string Name { get; set; }

        [DisplayName("The Price")]
        [Range(10 , 1000 , ErrorMessage = "value must between 10 and 1000")]
        public decimal Price {get; set; }

        [Required(ErrorMessage ="Please Enter The Date")]
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        [Required]
        [DisplayName("Category")]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        
        public mvcCategory? Category { get; set; }
    }
}
