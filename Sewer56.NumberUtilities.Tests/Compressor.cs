using Reloaded.Memory;
using Sewer56.NumberUtilities.Primitives;
using Xunit;
using Byte = Sewer56.NumberUtilities.Primitives.Byte;
using Double = Sewer56.NumberUtilities.Primitives.Double;
using SByte = Sewer56.NumberUtilities.Primitives.SByte;

namespace Sewer56.NumberUtilities.Tests
{
    public class Compressor
    {
        [Fact]
        public void CompressMaxValue()
        {
            int original = short.MaxValue;
            int maximum = short.MaxValue;

            var compressed = new CompressedNumber<int, Int, short, Short>(original, maximum);
            int decompressed = compressed.GetValue(maximum);

            Assert.Equal(original, decompressed);
        }

        [Fact]
        public void CompressMinValue()
        {
            int original = short.MinValue;
            int maximum = short.MaxValue;

            var compressed = new CompressedNumber<int, Int, short, Short>(original, maximum);
            int decompressed = compressed.GetValue(maximum);

            Assert.Equal(original, decompressed);
        }

        [Fact]
        public void CompressFloat()
        {
            float original = 1.214814305f;
            float maximum = 5f;

            var compressed = new CompressedNumber<float, Float, ushort, UShort>(original, maximum);
            float decompressed = compressed.GetValue(maximum);

            Assert.Equal(original, decompressed, 4);
        }

        [Fact]
        public void CompressFloatWithMin()
        {
            float original = 1.214814305f;
            float minimum = -2.5f;
            float maximum = 2.5f;

            var compressed = new CompressedNumber<float, Float, ushort, UShort>(original, minimum, maximum);
            float decompressed = compressed.GetValue(minimum, maximum);

            Assert.Equal(original, decompressed, 4);
        }

        [Fact]
        public void CompressDouble()
        {
            double original = 0.7286906838f;
            double maximum = 5f;

            var compressed = new CompressedNumber<double, Double, ushort, UShort>(original, maximum);
            double decompressed = compressed.GetValue(maximum);

            Assert.Equal(original, decompressed, 5);
        }

        [Fact]
        public void CompressDoubleWithMin()
        {
            double original = 0.7286906838f;
            double minimum = -2.5f;
            double maximum = 2.5f;

            var compressed = new CompressedNumber<double, Double, ushort, UShort>(original, minimum, maximum);
            double decompressed = compressed.GetValue(minimum, maximum);

            Assert.Equal(original, decompressed, 4);
        }

        [Fact]
        public unsafe void SizeOf()
        {
            Assert.Equal(1, sizeof(Byte));
            Assert.Equal(1, sizeof(SByte));
            Assert.Equal(2, sizeof(Short));
            Assert.Equal(2, sizeof(UShort));
            Assert.Equal(4, sizeof(Int));
            Assert.Equal(4, sizeof(UInt));
            Assert.Equal(8, sizeof(Long));
            Assert.Equal(8, sizeof(ULong));
            Assert.Equal(4, sizeof(Float));
            Assert.Equal(8, sizeof(Double));
        }

        [Fact]
        public unsafe void IsBlittable()
        {
            // Requires C# 8. Please ignore if Intellisense complains. Will compile and run.
            double original = 0.7286906838f;
            double maximum = 5f;

            var compressed = new CompressedNumber<double, Double, ushort, UShort>(original, maximum);
            var bytes = Struct.GetBytes(compressed);

            Struct.FromArray(bytes, out CompressedNumber<double, Double, ushort, UShort> fromBytes, 0);
            var decompressed = fromBytes.GetValue(maximum);

            Assert.Equal(original, decompressed, 5);
        }
    }
}
