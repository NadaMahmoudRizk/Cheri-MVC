using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cheri_Project.Models
{
    public class Product_Order
    {
        [Key]
        public int OrderID { get; set; }
        [ForeignKey("Product")]
        public int Product_ID { get; set; }
        public string User_ID { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int TotalStock { get; set; }
        public float TotalPrice { get; set; }
        public virtual Product Product { get; set; }
    }
}
