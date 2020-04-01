using System.Drawing;
using WallpaperGenerator.Models;

namespace WallpaperGenerator.Generators
{
    public class HorizontalGenerator : BaseGenerator
    {
        public override void Draw(Graphics graphics, Wallpaper config)
        {
            for (int col = 0; col < config.Size.Height; col += config.RectangleExternalSize.Width)
            {
                for (int row = 0; row < config.Size.Width; row += config.RectangleExternalSize.Height)
                {
                    graphics.DrawRectangle
                    (
                        new Pen
                        (
                            Color.FromArgb
                            (
                                col % (config.RectangleColour.R + 1),
                                col % (config.RectangleColour.G + 1),
                                col % (config.RectangleColour.B + 1)
                            ),
                            config.RectangleThickness
                        ),
                        row,
                        col,
                        config.RectangleInternalSize.Width,
                        config.RectangleInternalSize.Height
                    );
                }
            }
        }
    }
}
