using System;
using System.Drawing;
using WallpaperGenerator.Models;

namespace WallpaperGenerator.Generators
{
    public class FadeAlphaVerticalCentreGenerator : BaseGenerator
    {
        public override void Draw(Graphics graphics, Config config)
        {
            for (var row = 0; row < config.Size.Height; row += config.RectangleExternalSize.Height)
            {
                for (var col = 0; col < config.Size.Width; col += config.RectangleExternalSize.Height)
                {
                    var width = config.Size.Width / 2.0;
                    var percent = Math.Abs(col - width) / width;

                    var alpha = Convert.ToInt32(255 * percent);

                    graphics.DrawRectangle
                    (
                        new Pen
                        (
                            Color.FromArgb(alpha, config.RectangleColour),
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
