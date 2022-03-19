using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cheri_Project.Models
{
    public class Categories
    {
        public int ID { get; set; }
        [Unique]
        [Required]
        [MinLength(5, ErrorMessage = "Must be More Than 4")]
        [MaxLength(25, ErrorMessage = "Must be Less Than 25")]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        [RegularExpression(@"\w*\.(jpg|png)")]
        public string CategoryImage { get; set; }
        public virtual List<SubCategory> SubCategories { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
