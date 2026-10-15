using System.Globalization;
using FluentValidation.Resources;

namespace HouyarRealState.Application.Validators
{
    public class FluentValidationCustomLanguageManager : LanguageManager
    {
        public FluentValidationCustomLanguageManager()
        {
            Culture = new CultureInfo("fa-IR");
        }
    }
}
