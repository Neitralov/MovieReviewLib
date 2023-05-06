using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace MovieReviewLib.Data;

public class RequiredAtLeastOneItemAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        return value is IList { Count: > 0 };
    }        
}