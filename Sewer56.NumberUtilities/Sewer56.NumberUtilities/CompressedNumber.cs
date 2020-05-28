using Sewer56.NumberUtilities.Primitives.Interfaces;

namespace Sewer56.NumberUtilities
{
    /// <summary>
    /// Lossy compression that allows for representation of a number of type T as another number of type T.
    /// </summary>
    /// <typeparam name="TSource">The source number to be compressed inside another number format. (e.g. float)</typeparam>
    /// <typeparam name="TSourceNumber">The <see cref="INumber{T}"/> struct type belonging to the <see cref="TSource"/></typeparam>
    /// <typeparam name="TDestination">The destination number to be compressed inside another number format. (e.g. short) i.e. compresses float to short</typeparam>
    /// <typeparam name="TDestinationNumber">The <see cref="INumber{T}"/> struct type belonging to the <see cref="TDestination"/></typeparam>
    public struct CompressedNumber<TSource, TSourceNumber, TDestination, TDestinationNumber> 
        where TSource : unmanaged 
        where TDestination : unmanaged
        where TSourceNumber : INumber<TSource>
        where TDestinationNumber : INumber<TDestination>

    {
        /// <summary>
        /// The compressed form of the number value as another type T.
        /// </summary>
        public TDestinationNumber Value { get; private set; }

        /// <summary>
        /// Lossy compression that allows for representation of a number of type T as another number of type T.
        /// </summary>
        /// <param name="value">The value of the number to store.</param>
        /// <param name="maxValue">The maximum value the number can hold.</param>
        public CompressedNumber(TSourceNumber value, TSourceNumber maxValue)
        {
            Value = default;
            SetValue(value, maxValue);
        }

        /// <summary>
        /// Sets a new value.
        /// </summary>
        /// <param name="value">The value of the number to store.</param>
        /// <param name="maxValue">The maximum value the number can hold.</param>
        public void SetValue(TSourceNumber value, TSourceNumber maxValue)
        {
            Value = NumberCompressor<TDestination, TDestinationNumber>.Compress<TSource, TSourceNumber>(value, maxValue);
        }

        /// <summary>
        /// Returns the value of compressed number in another form.
        /// </summary>
        /// <param name="maxValue">The maximum value the number can hold.</param>
        public TSource GetValue(TSourceNumber maxValue)
        {
            return NumberCompressor<TDestination, TDestinationNumber>.Decompress<TSource, TSourceNumber>(Value, maxValue).Value;
        }
    }
}
