using Sewer56.NumberUtilities.Primitives.Interfaces;

namespace Sewer56.NumberUtilities.Primitives
{
    public struct Long : INumber<long>
    {
        public long Value { get; set; }

        public Long(float value)   => Value = (long) value;
        public Long(double value)  => Value = (long) value;
        public Long(byte value)    => Value = (long) value;
        public Long(short value)   => Value = (long) value;
        public Long(ushort value)  => Value = (long) value;
        public Long(int value)     => Value = (long) value;
        public Long(uint value)    => Value = (long) value;
        public Long(long value)    => Value = (long) value;
        public Long(ulong value)   => Value = (long) value;

        public long MaxValue       => long.MaxValue;
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

        public INumber<long> FromFloat(float value)      => new Long(value);
        public INumber<long> FromDouble(double value)    => new Long(value);
        public INumber<long> FromByte(byte value)        => new Long(value);
        public INumber<long> FromSByte(sbyte value)      => new Long(value);
        public INumber<long> FromShort(short value)      => new Long(value);
        public INumber<long> FromUShort(ushort value)    => new Long(value);
        public INumber<long> FromInt(int value)          => new Long(value);
        public INumber<long> FromUInt(uint value)        => new Long(value);
        public INumber<long> FromLong(long value)        => new Long(value);
        public INumber<long> FromULong(ulong value)      => new Long(value);

        public void SetValue(float value)    => Value = (long) value;
        public void SetValue(double value)   => Value = (long) value;
        public void SetValue(byte value)     => Value = (long) value;
        public void SetValue(sbyte value)    => Value = (long) value;
        public void SetValue(short value)    => Value = (long) value;
        public void SetValue(ushort value)   => Value = (long) value;
        public void SetValue(int value)      => Value = (long) value;
        public void SetValue(uint value)     => Value = (long) value;
        public void SetValue(long value)     => Value = (long) value;
        public void SetValue(ulong value)    => Value = (long) value;

        public static implicit operator Long(long l) => new Long(l);
    }
}
