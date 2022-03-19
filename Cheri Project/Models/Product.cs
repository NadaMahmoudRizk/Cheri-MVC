using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cheri_Project.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        [Display(Name ="Description")]
        public string ProductDescription { get; set; }
        [Display(Name = "Price")]

        public float ProductPrice { get; set; }
        public float Discount { get; set; }
        [ForeignKey("SubCategory")]
        [Display(Name = "SubCategory")]

        public int SubCategory_ID { get; set; }
        [ForeignKey("Category")]
        [Display(Name = "Category")]

        public int Category_ID { get; set; }
        public string Image { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual Categories Category { get; set; }
        public virtual List<Product_Order> Product_Orders { get; set; }
        public virtual List<Size> Sizes { get; set; }
        public virtual List<Image> Images { get; set; }
        public virtual List<Color> Colors { get; set; }



    }
}
