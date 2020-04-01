using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using WallpaperGenerator.Enumerations;
using WallpaperGenerator.Extensions;

namespace WallpaperGenerator.Models
{
    public class Config
    {
        public Color BackgroundColour { get; set; }

        public ImageFormat ImageFormat { get; set; }

        public Mode Mode { get; set; }

        public string OutputDirectory { get; set; }

        public Color RectangleColour { get; set; }

        public Size RectangleExternalSize { get; set; }

        public Size RectangleInternalSize { get; set; }

        public int RectangleThickness { get; set; }

        public Size Size { get; set; }

        public string GetFileName()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append(Mode);

            var properties = new List<int>
            {
                Size.Width,
                Size.Height,
                RectangleExternalSize.Width,
                RectangleExternalSize.Height,
                RectangleInternalSize.Width,
                RectangleInternalSize.Height,
                RectangleThickness,
                BackgroundColour.R,
                BackgroundColour.G,
                BackgroundColour.B,
                RectangleColour.R,
                RectangleColour.G,
                RectangleColour.B
            };

            const char separator = '-';

            foreach (var property in properties)
            {
                stringBuilder.Append(separator);
                stringBuilder.Append(property);
            }

            if (ImageFormat != null)
            {
                stringBuilder.Append('.');
                stringBuilder.Append(ImageFormat.GetFileExtension());
            }

            return stringBuilder.ToString();
        }
    }
}
