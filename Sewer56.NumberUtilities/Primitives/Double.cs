using Sewer56.NumberUtilities.Primitives.Interfaces;

namespace Sewer56.NumberUtilities.Primitives
{
    public struct Double : INumber<double>
    {
        public double Value { get; set; }

        public Double(float value)   => Value = (double) value;
        public Double(double value)  => Value = (double) value;
        public Double(byte value)    => Value = (double) value;
        public Double(short value)   => Value = (double) value;
        public Double(ushort value)  => Value = (double) value;
        public Double(int value)     => Value = (double) value;
        public Double(uint value)    => Value = (double) value;
        public Double(long value)    => Value = (double) value;
        public Double(ulong value)   => Value = (double) value;

        public double MaxValue      => double.MaxValue;
        public double MaxValueAsDouble => (double)MaxValue;

        public float AsFloat()      => (float)  Value;
        public double AsDouble()    => (double) Value;
        public byte AsByte()        => (byte)   Value;
        public sbyte AsSByte()      => (sbyte)  Value;
        public short AsShort()      => (short)  Value;
        public ushort AsUShort()    => (ushort) Value;
        public int AsInt()          => (int)    Value;
        public uint AsUInt()        => (uint)   Value;
        public long AsLong()        => (long)   Value;
        public ulong AsULong()      => (ulong)  Value;

        public INumber<double> FromFloat(float value)      => new Double(value);
        public INumber<double> FromDouble(double value)    => new Double(value);
        public INumber<double> FromByte(byte value)        => new Double(value);
        public INumber<double> FromSByte(sbyte value)      => new Double(value);
        public INumber<double> FromShort(short value)      => new Double(value);
        public INumber<double> FromUShort(ushort value)    => new Double(value);
        public INumber<double> FromInt(int value)          => new Double(value);
        public INumber<double> FromUInt(uint value)        => new Double(value);
        public INumber<double> FromLong(long value)        => new Double(value);
        public INumber<double> FromULong(ulong value)      => new Double(value);

        public void SetValue(float value)    => Value = (double) value;
        public void SetValue(double value)   => Value = (double) value;
        public void SetValue(byte value)     => Value = (double) value;
        public void SetValue(sbyte value)    => Value = (double) value;
        public void SetValue(short value)    => Value = (double) value;
        public void SetValue(ushort value)   => Value = (double) value;
        public void SetValue(int value)      => Value = (double) value;
        public void SetValue(uint value)     => Value = (double) value;
        public void SetValue(long value)     => Value = (double) value;
        public void SetValue(ulong value)    => Value = (double) value;

        public static implicit operator Double(double d) => new Double(d);
    }
}
