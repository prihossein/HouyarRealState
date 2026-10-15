using SixLabors.ImageSharp;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.Processing;
using HouyarRealState.Application.Wrappers;

namespace HouyarRealState.Application.Helpers
{
    public static class FileHelpers
    {
        public static async Task<string> SaveSmallImage(this IFormFile file, string path,
    double scale = 3.0, int dpi = 72, int quality = 70, ImageFormat outputFormat = ImageFormat.WEBP)
        {
            if (file == null || file.Length == 0)
                return "";

            string currentDirectory = Directory.GetCurrentDirectory();

            path = path.Trim('/');
            path = path.Replace("wwwroot/", "");
            path = $"wwwroot/{path}";

            string directoryPath = Path.Combine(currentDirectory, path);
            Directory.CreateDirectory(directoryPath);

            try
            {
                var originalFileName = Path.GetFileNameWithoutExtension(file.FileName).OptimizeForFiles();

                // پسوند فایل خروجی را بر اساس فرمت انتخابی تنظیم می‌کنیم
                string extension = "";

                switch (outputFormat)
                {
                    case ImageFormat.JPG:
                        extension = "jpg";
                        break;
                    case ImageFormat.WEBP:
                        extension = "webp";
                        break;
                }

                var smallFileName = $"small_{originalFileName}.{extension}";
                var savePath = Path.Combine(directoryPath, smallFileName);

                using var image = await Image.LoadAsync(file.OpenReadStream());

                int newWidth = (int)(image.Width / scale);
                int newHeight = (int)(image.Height / scale);

                // تغییر سایز تصویر
                image.Mutate(x => x.Resize(newWidth, newHeight));

                // تنظیم DPI در متادیتا (Exif)
                image.Metadata.ResolutionUnits = SixLabors.ImageSharp.Metadata.PixelResolutionUnit.PixelsPerInch;
                image.Metadata.HorizontalResolution = dpi;
                image.Metadata.VerticalResolution = dpi;



                if (outputFormat == ImageFormat.WEBP)
                {
                    await image.SaveAsync(savePath, new WebpEncoder { Quality = quality });

                }
                else // پیش‌فرض JPEG
                {
                    await image.SaveAsync(savePath, new JpegEncoder { Quality = quality });
                }

                return smallFileName;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static async Task<string> SaveSmallImage(this IFormFile file, string path, double scale = 3.0, int dpi = 72, int quality = 70)
        {
            if (file == null || file.Length == 0)
                return "";

            string currentDirectory = Directory.GetCurrentDirectory();

            path = path.Trim('/');
            path = path.Replace("wwwroot/", "");
            path = $"wwwroot/{path}";

            string directoryPath = Path.Combine(currentDirectory, path);
            Directory.CreateDirectory(directoryPath);

            try
            {
                var originalFileName = file.FileName.OptimizeForFiles();
                var smallFileName = $"small_{originalFileName}";
                var savePath = Path.Combine(directoryPath, smallFileName);

                using var image = await Image.LoadAsync(file.OpenReadStream());

                int newWidth = (int)(image.Width / scale);
                int newHeight = (int)(image.Height / scale);

                // تغییر سایز تصویر
                image.Mutate(x => x.Resize(newWidth, newHeight));

                // تنظیم DPI در متادیتا (Exif)
                image.Metadata.ResolutionUnits = SixLabors.ImageSharp.Metadata.PixelResolutionUnit.PixelsPerInch;
                image.Metadata.HorizontalResolution = dpi;
                image.Metadata.VerticalResolution = dpi;

                // ذخیره تصویر با کیفیت مشخص
                await image.SaveAsync(savePath, new JpegEncoder { Quality = quality });

                return smallFileName;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private static string GetContentType(string fileName)
        {
            var ext = Path.GetExtension(fileName).ToLowerInvariant();
            return ext switch
            {
                ".jpg" or ".jpeg" => "image/jpeg",
                ".png" => "image/png",
                ".gif" => "image/gif",
                ".webp" => "image/webp",
                ".bmp" => "image/bmp",
                _ => "application/octet-stream"
            };
        }

        public static async Task<string> SaveSmallImage(this IFormFile file, string path, int targetWidth = 400, int quality = 70)
        {
            if (file == null || file.Length == 0)
                return "";

            string currentDirectory = Directory.GetCurrentDirectory();

            path = path.Trim('/');
            path = path.Replace("wwwroot/", "");
            path = $"wwwroot/{path}";

            string directoryPath = Path.Combine(currentDirectory, path);
            Directory.CreateDirectory(directoryPath);

            try
            {
                var originalFileName = file.FileName.OptimizeForFiles();
                var smallFileName = $"small_{originalFileName}";
                var savePath = Path.Combine(directoryPath, smallFileName);

                using var image = await Image.LoadAsync(file.OpenReadStream());

                // تغییر سایز تصویر (با حفظ نسبت تصویر)
                image.Mutate(x => x.Resize(new ResizeOptions
                {
                    Size = new Size(targetWidth, 0),
                    Mode = ResizeMode.Max
                }));

                // ذخیره تصویر با کیفیت کمتر
                await image.SaveAsync(savePath, new JpegEncoder { Quality = quality });

                return smallFileName;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public static string UploadFile(this IFormFile file, string path,
    ImageFormat format = ImageFormat.JPG, int quality = 75, int dpi = 72)
        {
            if (file == null || file.Length <= 0)
                return "";

            string currentDirectory = Directory.GetCurrentDirectory();

            path = path.Trim('/');
            path = path.Replace("wwwroot/", "");
            path = $"wwwroot/{path}";

            try
            {
                var directoryPath = Path.Combine(currentDirectory, path);
                Directory.CreateDirectory(directoryPath);

                string fixedFileName = Path.GetFileNameWithoutExtension(file.FileName).OptimizeForFiles();
                string extension = format == ImageFormat.WEBP ? "webp" : "jpg";
                string fileName = $"{fixedFileName}.{extension}";
                string uploadPath = Path.Combine(directoryPath, fileName);

                // اگر فایل موجود بود، اسم یکتا تولید کن
                if (File.Exists(uploadPath))
                {
                    fileName = $"{NameGenerator.GenerateUniqCode()}-{fixedFileName}.{extension}";
                    uploadPath = Path.Combine(directoryPath, fileName);
                }

                // پردازش و ذخیره با ImageSharp
                using var image = Image.Load(file.OpenReadStream());

                // DPI تنظیم
                image.Metadata.ResolutionUnits = SixLabors.ImageSharp.Metadata.PixelResolutionUnit.PixelsPerInch;
                image.Metadata.HorizontalResolution = dpi;
                image.Metadata.VerticalResolution = dpi;

                // ذخیره بر اساس فرمت
                if (format == ImageFormat.WEBP)
                {
                    image.Save(uploadPath, new WebpEncoder { Quality = quality });
                }
                else
                {
                    image.Save(uploadPath, new JpegEncoder { Quality = quality });
                }

                return fileName;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public static string UploadFile(this IFormFile file, string path)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            path = path.Trim('/');
            path = path.Replace("wwwroot/", "");
            path = $"wwwroot/{path}";



            try
            {

                var directoryPatch = Path.Combine(currentDirectory, path);
                Directory.CreateDirectory(directoryPatch);

                if (file.Length <= 0) return "";
                string result = "";
                string uploadPath = "";
                string fixedFileName = file.FileName.OptimizeForFiles();

                //Exist New File Name And Upload
                uploadPath = Path.Combine(currentDirectory, path, fixedFileName);

                if (File.Exists(uploadPath))
                {
                    result = $"{NameGenerator.GenerateUniqCode()}-{fixedFileName}";
                    uploadPath = Path.Combine(currentDirectory, path, result);
                }
                else
                {
                    result = fixedFileName;
                    uploadPath = Path.Combine(currentDirectory, path, result);
                }

                using (var stream = new FileStream(uploadPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw;
            }
        }

        public static string UploadFile(this IFormFile file, string path, string fileName)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            path = path.Trim('/');
            path = path.Replace("wwwroot/", "");
            path = $"wwwroot/{path}";



            try
            {

                var directoryPatch = Path.Combine(currentDirectory, path);
                Directory.CreateDirectory(directoryPatch);

                if (file.Length <= 0) return "";
                string result = "";
                string uploadPath = "";
                string fixedFileName = fileName.OptimizeForFiles();

                //Exist New File Name And Upload
                uploadPath = Path.Combine(currentDirectory, path, fixedFileName);

                result = fixedFileName;
                uploadPath = Path.Combine(currentDirectory, path, result);

                using (var stream = new FileStream(uploadPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw;
            }
        }
    }
}
