using Sewer56.NumberUtilities.Primitives.Interfaces;

namespace Sewer56.NumberUtilities.Primitives
{
    public struct Int : INumber<int>
    {
        public int Value { get; set; }

        public Int(float value)   => Value = (int) value;
        public Int(double value)  => Value = (int) value;
        public Int(byte value)    => Value = (int) value;
        public Int(short value)   => Value = (int) value;
        public Int(ushort value)  => Value = (int) value;
        public Int(int value)     => Value = (int) value;
        public Int(uint value)    => Value = (int) value;
        public Int(long value)    => Value = (int) value;
        public Int(ulong value)   => Value = (int) value;

        public int MaxValue         => int.MaxValue;
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

        public INumber<int> FromFloat(float value)      => new Int(value);
        public INumber<int> FromDouble(double value)    => new Int(value);
        public INumber<int> FromByte(byte value)        => new Int(value);
        public INumber<int> FromSByte(sbyte value)      => new Int(value);
        public INumber<int> FromShort(short value)      => new Int(value);
        public INumber<int> FromUShort(ushort value)    => new Int(value);
        public INumber<int> FromInt(int value)          => new Int(value);
        public INumber<int> FromUInt(uint value)        => new Int(value);
        public INumber<int> FromLong(long value)        => new Int(value);
        public INumber<int> FromULong(ulong value)      => new Int(value);

        public void SetValue(float value)    => Value = (int) value;
        public void SetValue(double value)   => Value = (int) value;
        public void SetValue(byte value)     => Value = (int) value;
        public void SetValue(sbyte value)    => Value = (int) value;
        public void SetValue(short value)    => Value = (int) value;
        public void SetValue(ushort value)   => Value = (int) value;
        public void SetValue(int value)      => Value = (int) value;
        public void SetValue(uint value)     => Value = (int) value;
        public void SetValue(long value)     => Value = (int) value;
        public void SetValue(ulong value)    => Value = (int) value;

        public static implicit operator Int(int i) => new Int(i);
    }
}
