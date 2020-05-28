using Sewer56.NumberUtilities.Primitives.Interfaces;

namespace Sewer56.NumberUtilities.Primitives
{
    public struct ULong : INumber<ulong>
    {
        public ulong Value { get; set; }

        public ULong(float value)   => Value = (ulong) value;
        public ULong(double value)  => Value = (ulong) value;
        public ULong(byte value)    => Value = (ulong) value;
        public ULong(short value)   => Value = (ulong) value;
        public ULong(ushort value)  => Value = (ulong) value;
        public ULong(int value)     => Value = (ulong) value;
        public ULong(uint value)    => Value = (ulong) value;
        public ULong(long value)    => Value = (ulong) value;
        public ULong(ulong value)   => Value = (ulong) value;

        public ulong MaxValue       => ulong.MaxValue;
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

        public INumber<ulong> FromFloat(float value)      => new ULong(value);
        public INumber<ulong> FromDouble(double value)    => new ULong(value);
        public INumber<ulong> FromByte(byte value)        => new ULong(value);
        public INumber<ulong> FromSByte(sbyte value)      => new ULong(value);
        public INumber<ulong> FromShort(short value)      => new ULong(value);
        public INumber<ulong> FromUShort(ushort value)    => new ULong(value);
        public INumber<ulong> FromInt(int value)          => new ULong(value);
        public INumber<ulong> FromUInt(uint value)        => new ULong(value);
        public INumber<ulong> FromLong(long value)        => new ULong(value);
        public INumber<ulong> FromULong(ulong value)      => new ULong(value);

        public void SetValue(float value)    => Value = (ulong) value;
        public void SetValue(double value)   => Value = (ulong) value;
        public void SetValue(byte value)     => Value = (ulong) value;
        public void SetValue(sbyte value)    => Value = (ulong) value;
        public void SetValue(short value)    => Value = (ulong) value;
        public void SetValue(ushort value)   => Value = (ulong) value;
        public void SetValue(int value)      => Value = (ulong) value;
        public void SetValue(uint value)     => Value = (ulong) value;
        public void SetValue(long value)     => Value = (ulong) value;
        public void SetValue(ulong value)    => Value = (ulong) value;

        public static implicit operator ULong(ulong u) => new ULong(u);
    }
}
