using WallpaperGenerator.Enumerations;

namespace WallpaperGenerator.Generators
{
    public interface IGeneratorFactory
    {
        IGenerator CreateGenerator(Mode mode);
    }
}
