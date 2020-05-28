using Sewer56.NumberUtilities.Primitives.Interfaces;

namespace Sewer56.NumberUtilities.Primitives
{
    public struct UInt : INumber<uint>
    {
        public uint Value { get; set; }

        public UInt(float value)   => Value = (uint) value;
        public UInt(double value)  => Value = (uint) value;
        public UInt(byte value)    => Value = (uint) value;
        public UInt(short value)   => Value = (uint) value;
        public UInt(ushort value)  => Value = (uint) value;
        public UInt(int value)     => Value = (uint) value;
        public UInt(uint value)    => Value = (uint) value;
        public UInt(long value)    => Value = (uint) value;
        public UInt(ulong value)   => Value = (uint) value;

        public uint MaxValue        => uint.MaxValue;
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

        public INumber<uint> FromFloat(float value)      => new UInt(value);
        public INumber<uint> FromDouble(double value)    => new UInt(value);
        public INumber<uint> FromByte(byte value)        => new UInt(value);
        public INumber<uint> FromSByte(sbyte value)      => new UInt(value);
        public INumber<uint> FromShort(short value)      => new UInt(value);
        public INumber<uint> FromUShort(ushort value)    => new UInt(value);
        public INumber<uint> FromInt(int value)          => new UInt(value);
        public INumber<uint> FromUInt(uint value)        => new UInt(value);
        public INumber<uint> FromLong(long value)        => new UInt(value);
        public INumber<uint> FromULong(ulong value)      => new UInt(value);

        public void SetValue(float value)    => Value = (uint) value;
        public void SetValue(double value)   => Value = (uint) value;
        public void SetValue(byte value)     => Value = (uint) value;
        public void SetValue(sbyte value)    => Value = (uint) value;
        public void SetValue(short value)    => Value = (uint) value;
        public void SetValue(ushort value)   => Value = (uint) value;
        public void SetValue(int value)      => Value = (uint) value;
        public void SetValue(uint value)     => Value = (uint) value;
        public void SetValue(long value)     => Value = (uint) value;
        public void SetValue(ulong value)    => Value = (uint) value;

        public static implicit operator UInt(uint u) => new UInt(u);
    }
}
