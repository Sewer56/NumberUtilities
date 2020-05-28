using System;
using Sewer56.NumberUtilities.Primitives.Interfaces;

namespace Sewer56.NumberUtilities
{
    /// <summary>
    /// Compresses numbers such as floating points as numbers of other types between a value of -maxValue to maxvalue or 0 to maxValue.
    /// </summary>
    /// <typeparam name="TCompressed">The destination number to be compressed inside another number format. (e.g. short) i.e. compresses float to short</typeparam>
    /// <typeparam name="TCompressedNumber">The <see cref="INumber{T}"/> struct type belonging to the <see cref="TCompressed"/></typeparam>
    public static class NumberCompressor<TCompressed, TCompressedNumber> 
        where TCompressed : unmanaged
        where TCompressedNumber : INumber<TCompressed>
    {
        private static TCompressedNumber Instance { get; } = default;

        // Pack as Integer
        /// <summary>
        /// Packs a floating point number to an integer T, given the value of the number, the maximum value of the number and the maximum value of T.
        /// </summary>
        /// <param name="number">The value of the floating point.</param>
        /// <param name="maxValue">The maximum value the floating point can hold.</param>
        /// <returns>Compressed float value inside integer T.</returns>
        /// <typeparam name="TSource">The source number to be compressed inside another number format. (e.g. float)</typeparam>
        /// <typeparam name="TSourceNumber">The <see cref="INumber{T}"/> struct type belonging to the <see cref="TSource"/></typeparam>
        public static TCompressedNumber Compress<TSource, TSourceNumber>(TSourceNumber number, TSourceNumber maxValue) 
            where TSource : unmanaged
            where TSourceNumber : INumber<TSource>
        {
            double asCompressed = (number.AsDouble() / maxValue.AsDouble()) * Instance.MaxValueAsDouble;
            double rounded      = Math.Round(asCompressed, MidpointRounding.AwayFromZero);
            return (TCompressedNumber) Instance.FromDouble(rounded);
        }

        // Unpack to Float
        /// <summary>
        /// Unpacks a floating point number from an integer T, given the value of T, the maximum value of the number and the maximum value of T.
        /// </summary>
        /// <param name="number">The value of the floating point.</param>
        /// <param name="maxValue">The maximum value the floating point can hold.</param>
        /// <returns>Compressed float value inside integer T.</returns>
        /// <typeparam name="TSource">The source number to be compressed inside another number format. (e.g. float)</typeparam>
        /// <typeparam name="TSourceNumber">The <see cref="INumber{T}"/> struct type belonging to the <see cref="TSource"/></typeparam>
        public static TSourceNumber Decompress<TSource, TSourceNumber>(TCompressedNumber number, TSourceNumber maxValue)
            where TSource : unmanaged
            where TSourceNumber : INumber<TSource>
        {
            double asFraction = (number.AsDouble() / Instance.MaxValueAsDouble);
            return (TSourceNumber) maxValue.FromDouble(asFraction * maxValue.AsDouble());
        }
    }
}
