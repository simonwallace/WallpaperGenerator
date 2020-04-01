using System.Drawing;
using System.IO;
using WallpaperGenerator.Models;

namespace WallpaperGenerator.Generators
{
    public abstract class BaseGenerator : IGenerator
    {
        public Bitmap Generate(Config config)
        {
            var bitmap = new Bitmap(config.Size.Width, config.Size.Height);

            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(config.BackgroundColour);

                Draw(graphics, config);
            }

            return bitmap;
        }

        public abstract void Draw(Graphics graphics, Config config);

        public void Save(Config config, Bitmap image)
        {
            Directory.CreateDirectory(config.OutputDirectory);

            var filePath = Path.Combine(config.OutputDirectory, config.GetFileName());

            image.Save(filePath, config.ImageFormat);
        }
    }
}
