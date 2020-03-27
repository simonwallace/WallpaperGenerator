using System.Drawing.Imaging;
using WallpaperGenerator.Extensions;
using Xunit;

namespace WallpaperGenerator.Tests.Unit.ExtensionsTests.ImageFormatExtensionsTests
{
    public class GetFileExtensionsTests
    {
        public static TheoryData<ImageFormat, string> TestData => new TheoryData<ImageFormat, string>
        {
            { ImageFormat.Bmp, "bmp" },
            { ImageFormat.Emf, "emf" },
            { ImageFormat.Exif, "exif" },
            { ImageFormat.Gif, "gif" },
            { ImageFormat.Icon, "ico" },
            { ImageFormat.Jpeg, "jpg" },
            { ImageFormat.MemoryBmp, "memorybmp" },
            { ImageFormat.Png, "png" },
            { ImageFormat.Tiff, "tif" },
            { ImageFormat.Wmf, "wmf" }
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void When_I_supply_a_valid_image_format_Then_the_correct_file_extension_is_returned(ImageFormat format, string expected)
        {
            var actual = format.GetFileExtension();

            Assert.Equal(expected, actual);
        }
    }
}
