using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cheri_Project.Models
{
    public class Image
    {
        public int ID { get; set; }
        [Display(Name ="Image")]
        public string ImageName { get; set; }
        [ForeignKey("Product")]
        [Display(Name = "Product")]
        public int Product_ID { get; set; }
        public virtual Product Product { get; set; }
    }
}
