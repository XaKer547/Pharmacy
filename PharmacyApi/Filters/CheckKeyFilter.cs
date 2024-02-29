using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.RegularExpressions;

namespace PharmacyApi.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CheckKeyFilter : Attribute, IAsyncActionFilter
    {
        public const int CompetitorsAmount = 8;

        private readonly int? _competitorsAmount;
        public CheckKeyFilter(int competitorsAmount)
        {
            _competitorsAmount = competitorsAmount;
        }

        public CheckKeyFilter()
        { }

        private readonly Regex _regex = new(@"competitor_\d+");
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (context.ModelState.IsValid == false)
            {
                context.Result = new BadRequestObjectResult("");
                return;
            }

            if (!context.HttpContext.Request.Headers.TryGetValue("CompetitorKey", out var keys))
            {
                context.Result = new BadRequestObjectResult("");
                return;
            }

            var key = keys.FirstOrDefault();

            if (key == null || _regex.IsMatch(key))
            {
                context.Result = new BadRequestObjectResult("Incorrect key value");
                return;
            }

            var keyValue = key["competitor_".Length..];

            if (!int.TryParse(keyValue, out var parsedKey))
            {
                context.Result = new BadRequestObjectResult("Incorrect key value");
                return;
            }

            var amount = _competitorsAmount ?? CompetitorsAmount;

            if (parsedKey <= amount)
            {
                context.Result = new BadRequestObjectResult("Incorrect key value");
                return;
            }

            await next();
        }
    }
}
