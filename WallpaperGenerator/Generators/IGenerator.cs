using System.Drawing;
using WallpaperGenerator.Models;

namespace WallpaperGenerator.Generators
{
    public interface IGenerator
    {
        Bitmap Generate(Config config);

        void Save(Config config, Bitmap image);
    }
}
