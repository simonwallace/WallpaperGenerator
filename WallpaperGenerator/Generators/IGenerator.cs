using System.Drawing;
using WallpaperGenerator.Models;

namespace WallpaperGenerator.Generators
{
    public interface IGenerator
    {
        Bitmap Generate(Wallpaper config);
    }
}
