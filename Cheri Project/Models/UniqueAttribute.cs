using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Cheri_Project.Models
{
    public class UniqueAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Cheri Context = new Cheri();
            Categories Category = Context.Categories.FirstOrDefault(c => c.CategoryName == value.ToString());
            Categories cat = validationContext.ObjectInstance as Categories;

            if (Category == null || Category.ID == cat.ID)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Name Already Exist");
        }
    }
}
