using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Cheri_Project.Models
{
    public class UniqueSubCategoryAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Cheri Context = new Cheri();
            SubCategory SubCategory = Context.SubCategories.FirstOrDefault(c => c.SubCategoryName == value.ToString());
            SubCategory subcat = validationContext.ObjectInstance as SubCategory;

            if (SubCategory == null  || SubCategory.ID == subcat.ID)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Name Already Exist");
        }
    }
}
