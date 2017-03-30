using System.ComponentModel.DataAnnotations;

namespace BoilerPlate.App.Filters
{
    public class RequiredIfAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return (bool)value;
        }
    }
}