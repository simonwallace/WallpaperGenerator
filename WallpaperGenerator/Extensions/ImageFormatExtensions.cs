using System;
using System.Drawing.Imaging;
using System.Linq;

namespace WallpaperGenerator.Extensions
{
    /// <summary>
    /// Extensions to the <see cref="ImageFormat"/> class.
    /// </summary>
    public static class ImageFormatExtensions
    {
        /// <summary>
        /// Returns the file extension associated with the image format.
        /// </summary>
        /// <param name="format">The image format.</param>
        /// <returns>The file extension.</returns>
        public static string GetFileExtension(this ImageFormat format)
        {
            var imageDecoder = ImageCodecInfo
                .GetImageDecoders()
                .FirstOrDefault(f => f.FormatID == format.Guid);

            if (imageDecoder == null)
            {
                return format.GetDefaultFileExtension();
            }

            var fileExtension = imageDecoder
                .FilenameExtension
                .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .FirstOrDefault();

            if (fileExtension == null)
            {
                return format.GetDefaultFileExtension();
            }

            fileExtension = fileExtension
                .Trim('*', '.')
                .ToLower();

            return fileExtension;
        }

        /// <summary>
        /// Returns the default file extension for the image format.
        /// </summary>
        /// <param name="format">The image format.</param>
        /// <returns>The file extension.</returns>
        private static string GetDefaultFileExtension(this ImageFormat format)
        {
            return format.ToString().ToLower();
        }
    }
}
