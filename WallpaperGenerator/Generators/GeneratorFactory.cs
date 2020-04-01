using System;
using WallpaperGenerator.Enumerations;

namespace WallpaperGenerator.Generators
{
    public class GeneratorFactory : IGeneratorFactory
    {
        public IGenerator CreateGenerator(Mode mode)
        {
            switch (mode)
            {
                case Mode.DiagonalUp: return new DiagonalUpGenerator();
                case Mode.FadeAlphaVerticalCentre: return new FadeAlphaVerticalCentreGenerator();
                case Mode.FadeAlphaVerticalRight: return new FadeAlphaVerticalRightGenerator();
                case Mode.FadeColourVerticalCentre: return new FadeColourVerticalCentreGenerator();
                case Mode.Horizontal: return new HorizontalGenerator();
                case Mode.Vertical: return new VerticalGenerator();

                default: throw new NotSupportedException($"{mode} is not supported.");
            }
        }
    }
}
