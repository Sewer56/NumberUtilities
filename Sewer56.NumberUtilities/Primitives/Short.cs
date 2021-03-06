﻿using Sewer56.NumberUtilities.Primitives.Interfaces;

namespace Sewer56.NumberUtilities.Primitives
{
    public struct Short : INumber<short>
    {
        public short Value { get; set; }

        public Short(float value)   => Value = (short) value;
        public Short(double value)  => Value = (short) value;
        public Short(byte value)    => Value = (short) value;
        public Short(short value)   => Value = (short) value;
        public Short(ushort value)  => Value = (short) value;
        public Short(int value)     => Value = (short) value;
        public Short(uint value)    => Value = (short) value;
        public Short(long value)    => Value = (short) value;
        public Short(ulong value)   => Value = (short) value;

        public short MaxValue       => short.MaxValue;
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

        public INumber<short> FromFloat(float value)      => new Short(value);
        public INumber<short> FromDouble(double value)    => new Short(value);
        public INumber<short> FromByte(byte value)        => new Short(value);
        public INumber<short> FromSByte(sbyte value)      => new Short(value);
        public INumber<short> FromShort(short value)      => new Short(value);
        public INumber<short> FromUShort(ushort value)    => new Short(value);
        public INumber<short> FromInt(int value)          => new Short(value);
        public INumber<short> FromUInt(uint value)        => new Short(value);
        public INumber<short> FromLong(long value)        => new Short(value);
        public INumber<short> FromULong(ulong value)      => new Short(value);

        public short Add(short other) => (short)(Value + other);
        public short Subtract(short other) => (short)(Value - other);
        public short Multiply(short other) => (short)(Value * other);
        public short Divide(short other) => (short)(Value / other);

        public INumber<short> Add(INumber<short> other) => new Short(this.Value + other.Value);
        public INumber<short> Subtract(INumber<short> other) => new Short(this.Value - other.Value);
        public INumber<short> Multiply(INumber<short> other) => new Short(this.Value * other.Value);
        public INumber<short> Divide(INumber<short> other) => new Short(this.Value * other.Value);

        public void SetValue(float value)    => Value = (short) value;
        public void SetValue(double value)   => Value = (short) value;
        public void SetValue(byte value)     => Value = (short) value;
        public void SetValue(sbyte value)    => Value = (short) value;
        public void SetValue(short value)    => Value = (short) value;
        public void SetValue(ushort value)   => Value = (short) value;
        public void SetValue(int value)      => Value = (short) value;
        public void SetValue(uint value)     => Value = (short) value;
        public void SetValue(long value)     => Value = (short) value;
        public void SetValue(ulong value)    => Value = (short) value;

        public static implicit operator Short(short s) => new Short(s);
        public static implicit operator short(Short b) => b.Value;
    }
}
