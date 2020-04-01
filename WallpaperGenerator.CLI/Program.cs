using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using WallpaperGenerator.Enumerations;
using WallpaperGenerator.Generators;
using WallpaperGenerator.Models;

namespace WallpaperGenerator.CLI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new Config
            {
                BackgroundColour = Color.FromArgb(0, 0, 0),
                ImageFormat = ImageFormat.Png,
                Mode = Mode.Horizontal,
                OutputDirectory = Path.Combine
                (
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Desktop",
                    "WallpaperGenerator"
                ),
                RectangleColour = Color.FromArgb(255, 0, 0),
                RectangleExternalSize = new Size(10, 10),
                RectangleInternalSize = new Size(5, 5),
                RectangleThickness = 5,
                Size = new Size(1920, 1080)
            };

            var generator = new GeneratorFactory().CreateGenerator(config.Mode);

            using (var image = generator.Generate(config))
            {
                generator.Save(config, image);
            }
        }
    }
}
