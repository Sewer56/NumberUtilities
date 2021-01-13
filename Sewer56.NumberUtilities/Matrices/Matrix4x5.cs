using Sewer56.NumberUtilities.Primitives.Interfaces;
using Sewer56.NumberUtilities.Vectors;

namespace Sewer56.NumberUtilities.Matrices
{
    /// <summary>
    /// Represents a matrix composed of 4 elements.
    /// </summary>
    /// <typeparam name="TSource">The underlying number type behind the <see cref="TSourceNumber"/> (e.g. float)</typeparam>
    /// <typeparam name="TSourceNumber">The <see cref="INumber{T}"/> struct type belonging to the <see cref="TSource"/></typeparam>
    public struct Matrix4x5<TSource, TSourceNumber> where TSource : unmanaged where TSourceNumber : INumber<TSource>
    {
        public Vector5<TSource, TSourceNumber> X;
        public Vector5<TSource, TSourceNumber> Y;
        public Vector5<TSource, TSourceNumber> Z;
        public Vector5<TSource, TSourceNumber> W;

        public Matrix4x5(Vector5<TSource, TSourceNumber> x, Vector5<TSource, TSourceNumber> y, Vector5<TSource, TSourceNumber> z, Vector5<TSource, TSourceNumber> w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public Matrix4x5<TSource, TSourceNumber> Add(Matrix4x5<TSource, TSourceNumber> other) => new Matrix4x5<TSource, TSourceNumber>(X.Add(other.X), Y.Add(other.Y), Z.Add(other.Z), W.Add(other.W));
        public Matrix4x5<TSource, TSourceNumber> Subtract(Matrix4x5<TSource, TSourceNumber> other) => new Matrix4x5<TSource, TSourceNumber>(X.Subtract(other.X), Y.Subtract(other.Y), Z.Subtract(other.Z), W.Subtract(other.W));
        public Matrix4x5<TSource, TSourceNumber> Multiply(Matrix4x5<TSource, TSourceNumber> other) => new Matrix4x5<TSource, TSourceNumber>(X.Multiply(other.X), Y.Multiply(other.Y), Z.Multiply(other.Z), W.Multiply(other.W));
        public Matrix4x5<TSource, TSourceNumber> Divide(Matrix4x5<TSource, TSourceNumber> other) => new Matrix4x5<TSource, TSourceNumber>(X.Divide(other.X), Y.Divide(other.Y), Z.Divide(other.Z), W.Divide(other.W));
    }
}