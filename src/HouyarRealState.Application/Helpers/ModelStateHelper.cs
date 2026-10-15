using System.Text;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HouyarRealState.Application.Helpers
{
    public static class ModelStateHelper
    {
        public static string GetModelStateErrors(this ModelStateDictionary modelState)
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<ul>");

            foreach (var item in modelState)
            {

                foreach (var error in item.Value.Errors)
                {
                    sb.AppendLine($"<li>{error.ErrorMessage}</li>");
                }

            }


            sb.AppendLine("</ul>");
            return sb.ToString();
        }
    }
}
