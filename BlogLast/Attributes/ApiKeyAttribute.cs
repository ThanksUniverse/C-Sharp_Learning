using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BlogLast.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ApiKeyAttribute : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(
            ActionExecutingContext context,
            ActionExecutionDelegate next) //localhost:5001?api_key=chave
        {
            if (!context.HttpContext.Request.Query.TryGetValue(Configuration.ApiKeyName, out var extractApiKey))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "ApiKey nao encontrada"
                };
                return;
            }

            if (!Configuration.ApiKey.Equals(extractApiKey))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 403,
                    Content = "Acesso nao autorizado"
                };
                return;
            }

            await next();
        }
    }
}
