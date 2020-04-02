using System;
using System.Drawing;
using WallpaperGenerator.Models;

namespace WallpaperGenerator.Generators
{
    public class SineGenerator : BaseGenerator
    {
        public override void Draw(Graphics graphics, Config config)
        {
            var maxHeight = config.Size.Height;
            var midHeight = maxHeight / 2;

            for (int col = 0; col < config.Size.Width; col += config.RectangleExternalSize.Width)
            {
                var row = maxHeight - (Convert.ToInt32(Math.Sin(col * (Math.PI / 180)) * midHeight) + midHeight);

                graphics.DrawRectangle
                (
                    new Pen
                    (
                        config.RectangleColour,
                        config.RectangleThickness
                    ),
                    col,
                    row,
                    config.RectangleInternalSize.Width,
                    config.RectangleInternalSize.Height
                );
            }
        }
    }
}
