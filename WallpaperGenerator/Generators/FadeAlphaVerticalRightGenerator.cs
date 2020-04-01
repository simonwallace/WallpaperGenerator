using System;
using System.Drawing;
using WallpaperGenerator.Models;

namespace WallpaperGenerator.Generators
{
    public class FadeAlphaVerticalRightGenerator : BaseGenerator
    {
        public override void Draw(Graphics graphics, Config config)
        {
            for (var row = 0; row < config.Size.Height; row += config.RectangleExternalSize.Height)
            {
                for (var col = 0; col < config.Size.Width; col += config.RectangleExternalSize.Height)
                {
                    var width = (double)config.Size.Width;
                    var percent = (width - col) / width;

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
