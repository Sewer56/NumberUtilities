using Sewer56.NumberUtilities.Primitives.Interfaces;

namespace Sewer56.NumberUtilities.Vectors
{
    /// <summary>
    /// Represents a vector composed of 5 elements.
    /// </summary>
    /// <typeparam name="TSource">The underlying number type behind the <see cref="TSourceNumber"/> (e.g. float)</typeparam>
    /// <typeparam name="TSourceNumber">The <see cref="INumber{T}"/> struct type belonging to the <see cref="TSource"/></typeparam>
    public struct Vector5<TSource, TSourceNumber> where TSource : unmanaged where TSourceNumber : INumber<TSource>
    {
        public TSourceNumber X;
        public TSourceNumber Y;
        public TSourceNumber Z;
        public TSourceNumber W;
        public TSourceNumber V;

        public Vector5(TSourceNumber x, TSourceNumber y, TSourceNumber z, TSourceNumber w, TSourceNumber v)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
            V = v;
        }

        public Vector5<TSource, TSourceNumber> Add(Vector5<TSource, TSourceNumber> other) => new Vector5<TSource, TSourceNumber>((TSourceNumber) X.Add(other.X), (TSourceNumber) Y.Add(other.Y), (TSourceNumber) Z.Add(other.Z), (TSourceNumber) W.Add(other.W), (TSourceNumber) V.Add(other.V));
        public Vector5<TSource, TSourceNumber> Subtract(Vector5<TSource, TSourceNumber> other) => new Vector5<TSource, TSourceNumber>((TSourceNumber) X.Subtract(other.X), (TSourceNumber) Y.Subtract(other.Y), (TSourceNumber) Z.Subtract(other.Z), (TSourceNumber) W.Subtract(other.W), (TSourceNumber) V.Subtract(other.V));
        public Vector5<TSource, TSourceNumber> Multiply(Vector5<TSource, TSourceNumber> other) => new Vector5<TSource, TSourceNumber>((TSourceNumber) X.Multiply(other.X), (TSourceNumber) Y.Multiply(other.Y), (TSourceNumber) Z.Multiply(other.Z), (TSourceNumber) W.Multiply(other.W), (TSourceNumber) V.Multiply(other.V));
        public Vector5<TSource, TSourceNumber> Divide(Vector5<TSource, TSourceNumber> other) => new Vector5<TSource, TSourceNumber>((TSourceNumber) X.Divide(other.X), (TSourceNumber) Y.Divide(other.Y), (TSourceNumber) Z.Divide(other.Z), (TSourceNumber) W.Divide(other.W), (TSourceNumber) V.Divide(other.V));
    }
}