namespace Sewer56.NumberUtilities.Primitives.Interfaces
{
    /// <summary>
    /// Interface that represents a floating point or integer number, allowing for easy translations between types.
    /// </summary>
    public interface INumber<T> : INumber where T : unmanaged
    {
        /// <summary>
        /// The value of the underlying type.
        /// </summary>
        T Value { get; set; }

        /// <summary>
        /// Maximum value the number can hold.
        /// </summary>
        T MaxValue { get; }

        INumber<T> FromFloat(float value);
        INumber<T> FromDouble(double value);
        INumber<T> FromByte(byte value);
        INumber<T> FromSByte(sbyte value);
        INumber<T> FromShort(short value);
        INumber<T> FromUShort(ushort value);
        INumber<T> FromInt(int value);
        INumber<T> FromUInt(uint value);
        INumber<T> FromLong(long value);
        INumber<T> FromULong(ulong value);
    }

    public interface INumber
    {
        /// <summary>
        /// Maximum value the number can hold, as a double.
        /// </summary>
        double MaxValueAsDouble { get; }

        float AsFloat();
        double AsDouble();
        byte AsByte();
        sbyte AsSByte();
        short AsShort();
        ushort AsUShort();
        int AsInt();
        uint AsUInt();
        long AsLong();
        ulong AsULong();

        void SetValue(float value);
        void SetValue(double value);
        void SetValue(byte value);
        void SetValue(sbyte value);
        void SetValue(short value);
        void SetValue(ushort value);
        void SetValue(int value);
        void SetValue(uint value);
        void SetValue(long value);
        void SetValue(ulong value);
    }
}