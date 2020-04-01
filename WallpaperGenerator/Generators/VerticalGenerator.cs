using System.Drawing;
using WallpaperGenerator.Models;

namespace WallpaperGenerator.Generators
{
    public class VerticalGenerator : BaseGenerator
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
                                row % (config.RectangleColour.R + 1),
                                row % (config.RectangleColour.G + 1),
                                row % (config.RectangleColour.B + 1)
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
