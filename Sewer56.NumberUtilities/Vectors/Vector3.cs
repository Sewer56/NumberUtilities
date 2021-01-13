using Sewer56.NumberUtilities.Primitives.Interfaces;

namespace Sewer56.NumberUtilities.Vectors
{
    /// <summary>
    /// Represents a vector composed of 3 elements.
    /// </summary>
    /// <typeparam name="TSource">The underlying number type behind the <see cref="TSourceNumber"/> (e.g. float)</typeparam>
    /// <typeparam name="TSourceNumber">The <see cref="INumber{T}"/> struct type belonging to the <see cref="TSource"/></typeparam>
    public struct Vector3<TSource, TSourceNumber> where TSource : unmanaged where TSourceNumber : INumber<TSource>
    {
        public TSourceNumber X;
        public TSourceNumber Y;
        public TSourceNumber Z;

        public Vector3(TSourceNumber x, TSourceNumber y, TSourceNumber z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3<TSource, TSourceNumber> Add(Vector3<TSource, TSourceNumber> other) => new Vector3<TSource, TSourceNumber>((TSourceNumber) X.Add(other.X), (TSourceNumber) Y.Add(other.Y), (TSourceNumber) Z.Add(other.Z));
        public Vector3<TSource, TSourceNumber> Subtract(Vector3<TSource, TSourceNumber> other) => new Vector3<TSource, TSourceNumber>((TSourceNumber) X.Subtract(other.X), (TSourceNumber) Y.Subtract(other.Y), (TSourceNumber) Z.Subtract(other.Z));
        public Vector3<TSource, TSourceNumber> Multiply(Vector3<TSource, TSourceNumber> other) => new Vector3<TSource, TSourceNumber>((TSourceNumber) X.Multiply(other.X), (TSourceNumber) Y.Multiply(other.Y), (TSourceNumber) Z.Multiply(other.Z));
        public Vector3<TSource, TSourceNumber> Divide(Vector3<TSource, TSourceNumber> other) => new Vector3<TSource, TSourceNumber>((TSourceNumber) X.Divide(other.X), (TSourceNumber) Y.Divide(other.Y), (TSourceNumber) Z.Divide(other.Z));
    }
}