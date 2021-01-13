using Sewer56.NumberUtilities.Primitives.Interfaces;

namespace Sewer56.NumberUtilities.Primitives
{
    public struct UShort : INumber<ushort>
    {
        public ushort Value { get; set; }

        public UShort(float value)   => Value = (ushort) value;
        public UShort(double value)  => Value = (ushort) value;
        public UShort(byte value)    => Value = (ushort) value;
        public UShort(short value)   => Value = (ushort) value;
        public UShort(ushort value)  => Value = (ushort) value;
        public UShort(int value)     => Value = (ushort) value;
        public UShort(uint value)    => Value = (ushort) value;
        public UShort(long value)    => Value = (ushort) value;
        public UShort(ulong value)   => Value = (ushort) value;

        public ushort MaxValue      => ushort.MaxValue;
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

        public INumber<ushort> FromFloat(float value)      => new UShort(value);
        public INumber<ushort> FromDouble(double value)    => new UShort(value);
        public INumber<ushort> FromByte(byte value)        => new UShort(value);
        public INumber<ushort> FromSByte(sbyte value)      => new UShort(value);
        public INumber<ushort> FromShort(short value)      => new UShort(value);
        public INumber<ushort> FromUShort(ushort value)    => new UShort(value);
        public INumber<ushort> FromInt(int value)          => new UShort(value);
        public INumber<ushort> FromUInt(uint value)        => new UShort(value);
        public INumber<ushort> FromLong(long value)        => new UShort(value);
        public INumber<ushort> FromULong(ulong value)      => new UShort(value);

        public ushort Add(ushort other) => (ushort)(Value + other);
        public ushort Subtract(ushort other) => (ushort)(Value - other);
        public ushort Multiply(ushort other) => (ushort)(Value * other);
        public ushort Divide(ushort other) => (ushort)(Value / other);

        public INumber<ushort> Add(INumber<ushort> other) => new UShort(this.Value + other.Value);
        public INumber<ushort> Subtract(INumber<ushort> other) => new UShort(this.Value - other.Value);
        public INumber<ushort> Multiply(INumber<ushort> other) => new UShort(this.Value * other.Value);
        public INumber<ushort> Divide(INumber<ushort> other) => new UShort(this.Value * other.Value);

        public void SetValue(float value)    => Value = (ushort) value;
        public void SetValue(double value)   => Value = (ushort) value;
        public void SetValue(byte value)     => Value = (ushort) value;
        public void SetValue(sbyte value)    => Value = (ushort) value;
        public void SetValue(short value)    => Value = (ushort) value;
        public void SetValue(ushort value)   => Value = (ushort) value;
        public void SetValue(int value)      => Value = (ushort) value;
        public void SetValue(uint value)     => Value = (ushort) value;
        public void SetValue(long value)     => Value = (ushort) value;
        public void SetValue(ulong value)    => Value = (ushort) value;

        public static implicit operator UShort(ushort u) => new UShort(u);
        public static implicit operator ushort(UShort b) => b.Value;
    }
}
