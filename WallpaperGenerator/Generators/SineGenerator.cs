using System;
using System.Drawing;
using WallpaperGenerator.Models;

namespace WallpaperGenerator.Generators
{
    public class SineGenerator : BaseGenerator
    {
        public override void Draw(Graphics graphics, Config config)
        {
            var maxHeight = config.Size.Height - config.RectangleInternalSize.Height;
            var midHeight = maxHeight / 2d;

            var startIndex = config.RectangleInternalSize.Width * -1;

            for (int col = startIndex; col < config.Size.Width; col += config.RectangleExternalSize.Width)
            {
                var row = midHeight - (Math.Sin(col * (Math.PI / 180d)) * midHeight);

                var brush = new SolidBrush(config.RectangleColour);
                var rectangle = new Rectangle(new Point(col, (int)row), config.RectangleInternalSize);

                graphics.DrawEllipse(new Pen(brush), rectangle);
                graphics.FillEllipse(brush, rectangle);
            }
        }
    }
}
