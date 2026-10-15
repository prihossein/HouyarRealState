using System.Drawing;
using Microsoft.AspNetCore.Http;

namespace HouyarRealState.Application.Helpers
{
    public static class ImageHelper
    {
        public static bool IsImage(this IFormFile file)
        {
            try
            {
                var img = Image.FromStream(file.OpenReadStream());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CheckMaxDimension(this IFormFile file, int maxHeight, int maxWidth)
        {
            Image image = Image.FromStream(file.OpenReadStream());
            int width = image.Width;
            int height = image.Height;
            if ((width > maxWidth) || (height > maxHeight))
            {
                return false;
            }

            return true;
        }
    }
}
