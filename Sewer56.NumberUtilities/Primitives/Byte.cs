using Sewer56.NumberUtilities.Primitives.Interfaces;

namespace Sewer56.NumberUtilities.Primitives
{
    public struct Byte : INumber<byte>
    {
        public byte Value { get; set; }

        public Byte(float value)   => Value = (byte) value;
        public Byte(double value)  => Value = (byte) value;
        public Byte(byte value)    => Value = (byte) value;
        public Byte(short value)   => Value = (byte) value;
        public Byte(ushort value)  => Value = (byte) value;
        public Byte(int value)     => Value = (byte) value;
        public Byte(uint value)    => Value = (byte) value;
        public Byte(long value)    => Value = (byte) value;
        public Byte(ulong value)   => Value = (byte) value;

        public byte MaxValue       => byte.MaxValue;
        public double MaxValueAsDouble => (double) MaxValue;

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

        public INumber<byte> FromFloat(float value)      => new Byte(value);
        public INumber<byte> FromDouble(double value)    => new Byte(value);
        public INumber<byte> FromByte(byte value)        => new Byte(value);
        public INumber<byte> FromSByte(sbyte value)      => new Byte(value);
        public INumber<byte> FromShort(short value)      => new Byte(value);
        public INumber<byte> FromUShort(ushort value)    => new Byte(value);
        public INumber<byte> FromInt(int value)          => new Byte(value);
        public INumber<byte> FromUInt(uint value)        => new Byte(value);
        public INumber<byte> FromLong(long value)        => new Byte(value);
        public INumber<byte> FromULong(ulong value)      => new Byte(value);

        public byte Add(byte other) => (byte) (Value + other);
        public byte Subtract(byte other) => (byte) (Value - other);
        public byte Multiply(byte other) => (byte) (Value * other);
        public byte Divide(byte other) => (byte) (Value / other);

        public void SetValue(float value)    => Value = (byte) value;
        public void SetValue(double value)   => Value = (byte) value;
        public void SetValue(byte value)     => Value = (byte) value;
        public void SetValue(sbyte value)    => Value = (byte) value;
        public void SetValue(short value)    => Value = (byte) value;
        public void SetValue(ushort value)   => Value = (byte) value;
        public void SetValue(int value)      => Value = (byte) value;
        public void SetValue(uint value)     => Value = (byte) value;
        public void SetValue(long value)     => Value = (byte) value;
        public void SetValue(ulong value)    => Value = (byte) value;

        public static implicit operator Byte(byte b) => new Byte(b);
        public static implicit operator byte(Byte b) => b.Value;
    }
}
