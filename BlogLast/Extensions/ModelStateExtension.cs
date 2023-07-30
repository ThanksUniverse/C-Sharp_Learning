using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging.Abstractions;

namespace BlogLast.Extensions
{
    public static class ModelStateExtension
    {
        public static List<string> GetErrors(this ModelStateDictionary modelState)
        {
            var result = new List<string>();
            foreach (var item in modelState.Values) // Add range
                result.AddRange(item.Errors.Select(error => error.ErrorMessage));

            return result;
        }
    }
}
