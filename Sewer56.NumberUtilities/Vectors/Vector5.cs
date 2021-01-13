using Sewer56.NumberUtilities.Primitives.Interfaces;

namespace Sewer56.NumberUtilities.Vectors
{
    /// <summary>
    /// Represents a vector composed of 5 elements.
    /// </summary>
    /// <typeparam name="TSource">The underlying number type behind the <see cref="TSourceNumber"/> (e.g. float)</typeparam>
    /// <typeparam name="TSourceNumber">The <see cref="INumber{T}"/> struct type belonging to the <see cref="TSource"/></typeparam>
    public struct Vector5<TSource, TSourceNumber> where TSource : unmanaged, INumber<TSource>
    {
        public TSource X;
        public TSource Y;
        public TSource Z;
        public TSource W;
        public TSource V;

        public Vector5(TSource x, TSource y, TSource z, TSource w, TSource v)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
            V = v;
        }

        public Vector5<TSource, TSourceNumber> Add(Vector5<TSource, TSourceNumber> other) => new Vector5<TSource, TSourceNumber>(X.Add(other.X), Y.Add(other.Y), Z.Add(other.Z), W.Add(other.W), V.Add(other.V));
        public Vector5<TSource, TSourceNumber> Subtract(Vector5<TSource, TSourceNumber> other) => new Vector5<TSource, TSourceNumber>(X.Subtract(other.X), Y.Subtract(other.Y), Z.Subtract(other.Z), W.Subtract(other.W), V.Subtract(other.V));
        public Vector5<TSource, TSourceNumber> Multiply(Vector5<TSource, TSourceNumber> other) => new Vector5<TSource, TSourceNumber>(X.Multiply(other.X), Y.Multiply(other.Y), Z.Multiply(other.Z), W.Multiply(other.W), V.Multiply(other.V));
        public Vector5<TSource, TSourceNumber> Divide(Vector5<TSource, TSourceNumber> other) => new Vector5<TSource, TSourceNumber>(X.Divide(other.X), Y.Divide(other.Y), Z.Divide(other.Z), W.Divide(other.W), V.Divide(other.V));
    }
}