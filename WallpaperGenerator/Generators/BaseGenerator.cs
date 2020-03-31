using System.Drawing;
using WallpaperGenerator.Models;

namespace WallpaperGenerator.Generators
{
    public abstract class BaseGenerator : IGenerator
    {
        public Bitmap Generate(Wallpaper config)
        {
            var bitmap = new Bitmap(config.Size.Width, config.Size.Height);

            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(config.BackgroundColour);

                Draw(graphics, config);
            }

            return bitmap;
        }

        public abstract void Draw(Graphics graphics, Wallpaper config);
    }
}
