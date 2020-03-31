using System.Drawing;
using System.Drawing.Imaging;
using WallpaperGenerator.Enumerations;

namespace WallpaperGenerator.Models
{
    public class Wallpaper
    {
        public Color BackgroundColour { get; set; }

        public ImageFormat Format { get; set; }

        public Mode Mode { get; set; }

        public Color RectangleColour { get; set; }

        public Size RectangleExternalSize { get; set; }

        public Size RectangleInternalSize { get; set; }

        public int RectangleThickness { get; set; }

        public Size Size { get; set; }
    }
}
