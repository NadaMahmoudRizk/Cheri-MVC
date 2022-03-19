using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cheri_Project.Models
{
    public class SubCategory
    {
        public int ID { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Must be More Than 4")]
        [MaxLength(25, ErrorMessage = "Must be Less Than 25")]
        [Display(Name = "Collection Name")]
        [UniqueSubCategoryAttribute]
        [RegularExpression(@"\w*\ For (Women|Men|Kid)",ErrorMessage ="The SubCategory must be End With For Men or For Women or For Kid")]
        public string SubCategoryName { get; set; }
        [ForeignKey("Categories")]
        [Display(Name ="Category")]
        public int Category_ID { get; set; }
        public virtual Categories Categories { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
