using System;
using System.Drawing;
using WallpaperGenerator.Models;

namespace WallpaperGenerator.Generators
{
    public class FadeColourVerticalCentreGenerator : BaseGenerator
    {
        public override void Draw(Graphics graphics, Config config)
        {
            for (var row = 0; row < config.Size.Height; row += config.RectangleExternalSize.Height)
            {
                for (var col = 0; col < config.Size.Width; col += config.RectangleExternalSize.Height)
                {
                    var width = config.Size.Width / 2.0;
                    var percent = Math.Abs(col - width) / width;

                    var red = Convert.ToInt32(config.RectangleColour.R * percent);
                    var green = Convert.ToInt32(config.RectangleColour.G * percent);
                    var blue = Convert.ToInt32(config.RectangleColour.B * percent);

                    graphics.DrawRectangle
                    (
                        new Pen
                        (
                            Color.FromArgb(red, green, blue),
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
}
