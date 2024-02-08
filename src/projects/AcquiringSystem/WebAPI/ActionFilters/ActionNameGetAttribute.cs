using Core.CrossCuttingConcerns.Exceptions.Types;
using Microsoft.AspNetCore.Mvc.Filters;
using WebAPI.Models;

namespace WebAPI.ActionFilters
{
    // BU KISIM ALIŞTIRMA YAPMAK İÇİN YAPILMIŞTIR. BELİRLİ BİR AMACI YOKTUR.

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class ActionNameGetAttribute : Microsoft.AspNetCore.Mvc.Filters.ActionFilterAttribute
    {
        private readonly string _headerKey;
        public ActionNameGetAttribute(string headerKey= "Action-Name")
        {
            this._headerKey = headerKey;
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context,ActionExecutionDelegate next)
        {
            if (!context.ActionDescriptor.FilterDescriptors.Any(i => i.Filter.GetType() == typeof(ActionNameGetAttribute)))
            {
                await next();
                return;
            }
            var header = context.HttpContext.Request.Headers;

            if (header is null || !header.Any() || !header.ContainsKey(_headerKey))
                throw new AuthorizationException("Lütfen Header bilgisini eksiksiz yollayınız!");

            var actionName = header[_headerKey].ToString();

            var actionModel = context.HttpContext.RequestServices.GetService(typeof(ActionNameModel)) as ActionNameModel;

            actionModel.Name = actionName;

            await next();
        }

    }
}
