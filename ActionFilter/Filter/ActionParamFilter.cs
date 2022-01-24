using ActionFilter.Extensions;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilter.Filter;

public class ActionParamFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        var parameterDescriptors = context.ActionDescriptor.Parameters.ToList();

        var @params = parameterDescriptors.Where(p => p.ParameterType.IsAssignableTo(typeof(string))).ToList();

        foreach (var param in @params)
        {
            if (context.ActionArguments[param.Name] is null)
            {
                continue;
            }

            var value = (string)context.ActionArguments[param.Name];

            if (!string.IsNullOrWhiteSpace(value))
            {
                context.ActionArguments[param.Name] = value.ReverseIt();
            }
        }
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        return;
    }
}