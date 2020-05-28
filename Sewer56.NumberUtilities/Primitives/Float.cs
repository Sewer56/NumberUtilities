using Sewer56.NumberUtilities.Primitives.Interfaces;

namespace Sewer56.NumberUtilities.Primitives
{
    public struct Float : INumber<float>
    {
        public float Value { get; set; }

        public Float(float value)   => Value = (float) value;
        public Float(double value)  => Value = (float) value;
        public Float(byte value)    => Value = (float) value;
        public Float(short value)   => Value = (float) value;
        public Float(ushort value)  => Value = (float) value;
        public Float(int value)     => Value = (float) value;
        public Float(uint value)    => Value = (float) value;
        public Float(long value)    => Value = (float) value;
        public Float(ulong value)   => Value = (float) value;

        public float MaxValue       => float.MaxValue;
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

        public INumber<float> FromFloat(float value)      => new Float(value);
        public INumber<float> FromDouble(double value)    => new Float(value);
        public INumber<float> FromByte(byte value)        => new Float(value);
        public INumber<float> FromSByte(sbyte value)      => new Float(value);
        public INumber<float> FromShort(short value)      => new Float(value);
        public INumber<float> FromUShort(ushort value)    => new Float(value);
        public INumber<float> FromInt(int value)          => new Float(value);
        public INumber<float> FromUInt(uint value)        => new Float(value);
        public INumber<float> FromLong(long value)        => new Float(value);
        public INumber<float> FromULong(ulong value)      => new Float(value);

        public void SetValue(float value)    => Value = (float) value;
        public void SetValue(double value)   => Value = (float) value;
        public void SetValue(byte value)     => Value = (float) value;
        public void SetValue(sbyte value)    => Value = (float) value;
        public void SetValue(short value)    => Value = (float) value;
        public void SetValue(ushort value)   => Value = (float) value;
        public void SetValue(int value)      => Value = (float) value;
        public void SetValue(uint value)     => Value = (float) value;
        public void SetValue(long value)     => Value = (float) value;
        public void SetValue(ulong value)    => Value = (float) value;

        public static implicit operator Float(float f) => new Float(f);
    }
}
