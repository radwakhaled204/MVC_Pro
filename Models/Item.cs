using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mvc_train.Models
{
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

    }
}
