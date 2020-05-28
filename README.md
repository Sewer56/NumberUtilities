# Sewer56.NumberUtilities

[![Build status](https://ci.appveyor.com/api/projects/status/pdbufjv1h66ki40v?svg=true)](https://ci.appveyor.com/project/sewer56lol/numberutilities) [![Test status](https://img.shields.io/appveyor/tests/sewer56lol/numberutilities)](https://ci.appveyor.com/project/sewer56lol/numberutilities)

This library contains various utilities and extension methods I use in my projects on a semi-regular basis. You are welcome to use them too, either by copy-pasting them or by referencing this library.

# Quick Overview

## Generic Number Types

Designed to work around the problem of C#'s lack of a numeric generic constraints, the `INumber` interface exists to allow for conversion between arbitrary number types to other arbitrary number types.

This allows for performing arithmetic between different types of generic numbers which the language may not normally allow for.

**For Example**:

```csharp
// Multiply two generic numbers.
public static TDestinationNumber Multiply<TSourceNumber, TDestinationNumber>(TSourceNumber a, TDestinationNumber b)
    where TSourceNumber : INumber
    where TDestinationNumber : INumber
{
    TDestinationNumber result = default;
    result.SetValue(a.AsDouble() * b.AsDouble());
    return result;
}
```

**Usage**:

```csharp
var genericFloat = Multiply<int, Int, float, Float>(a, b);
```


**For more advanced usage**, you can also utilize the full `INumber<T>` interface:

```csharp
// Casts one generic number into another generic number.
public static TDestinationNumber Cast<TSource, TSourceNumber, TDestination, TDestinationNumber>(TSourceNumber a)
    where TSource : unmanaged
    where TSourceNumber : INumber<TSource>
    where TDestination : unmanaged
    where TDestinationNumber : INumber<TDestination>
{
    TDestinationNumber result = default;
    return (TDestinationNumber) result.FromDouble(a.AsDouble());
}
```

Default implementations of numbers can be found in the `Sewer56.NumberUtilities.Primitives` namespace.

## Number Compression

Derived from Generic Number Types, another utility in this repository is a universal number compressor. This compressor `CompressedNumber<>` is a general purpose utility for storing large integer and floating point numbers as smaller integers.

It works under the hood by using linear interpolation. More specifically: `(number.AsDouble() / maxValue.AsDouble()) * TDestination.MaxValueAsDouble` where `number` is the value passed by the user, `TDestination` is the type to compress to and `maxValue` is the maximum value that `number` can be.

```csharp
// Set value and maximum allowed value.
double original = 0.7286906838f;
double maximum = 5f;

// Store a double (8 bytes) as a ushort (2 bytes)
var compressed = new CompressedNumber<double, Double, ushort, UShort>(original, maximum);
double decompressed = compressed.GetValue(maximum);

// Still accurate to 5 decimal places
Assert.Equal(original, decompressed, 5);
```

Compression and decompression is extremely fast, almost as fast as a non-generic version.
Despite the use of an interface, there is no overhead in terms of virtual method calls; the trick comes in an extremely rarely known trick and the use of the `where` constraint. You can find some details about it in [this ancient article.](https://www.codeproject.com/Articles/8531/Using-generics-for-calculations) It is an interesting read.

### Compressed Numbers are Blittable
There is no trickery involved in storage of a compressed number. All compressed numbers can be safely passed to native code or serialized.

```csharp
[Fact]
public unsafe void IsBlittable()
{
    // Requires C# 8. Please ignore if Intellisense complains. Will compile and run.
    double original = 0.7286906838f;
    double maximum = 5f;

	// Convert compressed to byte array, and read back out from byte array. 
    var compressed = new CompressedNumber<double, Double, ushort, UShort>(original, maximum);
    var bytes = Struct.GetBytes(compressed);

    Struct.FromArray(bytes, out CompressedNumber<double, Double, ushort, UShort> fromBytes, 0);
    var decompressed = fromBytes.GetValue(maximum);

    Assert.Equal(original, decompressed, 5);
}
```

I mainly use this to compress packets to be sent over the network where lossy compression may be acceptable for floating point numbers. All that's necessary is for the 2 clients to agree on a shared maximum value.