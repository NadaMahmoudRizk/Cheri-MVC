using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cheri_Project.Models
{
    public class Size
    {
        public int ID { get; set; }
        [Display(Name = "Size")]
        public string SizeName { get; set; }
        [ForeignKey("Product")]
        [Display(Name = "Product")]
        public int Product_ID { get; set; }
        public virtual Product Product { get; set; }
    }
}
