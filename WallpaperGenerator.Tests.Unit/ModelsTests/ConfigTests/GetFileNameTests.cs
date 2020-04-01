using System.Drawing;
using System.Drawing.Imaging;
using WallpaperGenerator.Enumerations;
using WallpaperGenerator.Models;
using Xunit;

namespace WallpaperGenerator.Tests.Unit.ModelsTests.ConfigTests
{
    public class GetFileNameTests
    {
        public static TheoryData<Config, string> TestData => new TheoryData<Config, string>
        {
            {
                new Config
                {
                    BackgroundColour = Color.FromArgb(200, 6, 19),
                    ImageFormat = ImageFormat.Png,
                    Mode = Mode.FadeAlphaVerticalRight,
                    RectangleColour = Color.FromArgb(84, 109, 250),
                    RectangleExternalSize = new Size(600, 10),
                    RectangleInternalSize = new Size(15, 8),
                    RectangleThickness = 55,
                    Size = new Size(1009, 2001)
                },
                "FadeAlphaVerticalRight-1009-2001-600-10-15-8-55-200-6-19-84-109-250.png"
            },
            {
                new Config(),
                "Undefined-0-0-0-0-0-0-0-0-0-0-0-0-0"
            }
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void When_I_supply_a_valid_config_Then_the_correct_file_name_is_returned(Config config, string expected)
        {
            var actual = config.GetFileName();

            Assert.Equal(expected, actual);
        }
    }
}
