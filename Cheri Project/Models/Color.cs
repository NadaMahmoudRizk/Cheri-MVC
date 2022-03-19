using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cheri_Project.Models
{
    public class Color
    {
        public int ID { get; set; }
        [Display(Name = "Color")]
        public string ColorName { get; set; }
        [ForeignKey("Product")]
        [Display(Name = "Product")]
        public int Product_ID { get; set; }
        public virtual Product Product { get; set; }
    }
}
