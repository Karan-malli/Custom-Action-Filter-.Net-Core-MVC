using Microsoft.AspNetCore.Mvc.Filters;

namespace CustomActionFilter.Filters
{
    public class DateTimeConvertor : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            object model = null;

            if (context.ActionArguments.TryGetValue("model", out var Model))
            {
                model = Model;
            }
            else if (context.ActionArguments.TryGetValue("viewmodel", out var ViewModel))
            {
                model = ViewModel;
            }

            if (model != null)
            {
                var properties = model.GetType().GetProperties();
                foreach (var property in properties)
                {
                    if (property.PropertyType == typeof(DateTime))
                    {
                        DateTime value = (DateTime)property.GetValue(model);
                        property.SetValue(model, value.ToUniversalTime());

                    }
                }
                base.OnActionExecuting(context);
            }
        }
    }
}
