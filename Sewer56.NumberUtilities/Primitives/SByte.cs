using Sewer56.NumberUtilities.Primitives.Interfaces;

namespace Sewer56.NumberUtilities.Primitives
{
    public struct SByte : INumber<sbyte>
    {
        public sbyte Value { get; set; }

        public SByte(float value)   => Value = (sbyte) value;
        public SByte(double value)  => Value = (sbyte) value;
        public SByte(byte value)    => Value = (sbyte) value;
        public SByte(short value)   => Value = (sbyte) value;
        public SByte(ushort value)  => Value = (sbyte) value;
        public SByte(int value)     => Value = (sbyte) value;
        public SByte(uint value)    => Value = (sbyte) value;
        public SByte(long value)    => Value = (sbyte) value;
        public SByte(ulong value)   => Value = (sbyte) value;

        public sbyte MaxValue       => sbyte.MaxValue;
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

        public INumber<sbyte> FromFloat(float value)      => new SByte(value);
        public INumber<sbyte> FromDouble(double value)    => new SByte(value);
        public INumber<sbyte> FromByte(byte value)        => new SByte(value);
        public INumber<sbyte> FromSByte(sbyte value)      => new SByte(value);
        public INumber<sbyte> FromShort(short value)      => new SByte(value);
        public INumber<sbyte> FromUShort(ushort value)    => new SByte(value);
        public INumber<sbyte> FromInt(int value)          => new SByte(value);
        public INumber<sbyte> FromUInt(uint value)        => new SByte(value);
        public INumber<sbyte> FromLong(long value)        => new SByte(value);
        public INumber<sbyte> FromULong(ulong value)      => new SByte(value);

        public sbyte Add(sbyte other) => (sbyte)(Value + other);
        public sbyte Subtract(sbyte other) => (sbyte)(Value - other);
        public sbyte Multiply(sbyte other) => (sbyte)(Value * other);
        public sbyte Divide(sbyte other) => (sbyte)(Value / other);

        public void SetValue(float value)    => Value = (sbyte) value;
        public void SetValue(double value)   => Value = (sbyte) value;
        public void SetValue(byte value)     => Value = (sbyte) value;
        public void SetValue(sbyte value)    => Value = (sbyte) value;
        public void SetValue(short value)    => Value = (sbyte) value;
        public void SetValue(ushort value)   => Value = (sbyte) value;
        public void SetValue(int value)      => Value = (sbyte) value;
        public void SetValue(uint value)     => Value = (sbyte) value;
        public void SetValue(long value)     => Value = (sbyte) value;
        public void SetValue(ulong value)    => Value = (sbyte) value;

        public static implicit operator SByte(sbyte b) => new SByte(b);
        public static implicit operator sbyte(SByte b) => b.Value;
    }
}
