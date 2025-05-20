using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefStructEnhancements;

// allows ref struct - generic type "anti-constraint"
// Before C# 13, ref struct types couldn't be declared as the type argument for a generic type or method.
// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13#allows-ref-struct

// ref struct interfaces
// Before C# 13, ref struct types weren't allowed to implement interfaces. Beginning with C# 13, they can.
// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13#ref-struct-interfaces

// ref and unsafe in iterators and async methods
// allows more functionality for Span and ReadOnlySpan
// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13#ref-and-unsafe-in-iterators-and-async-methods
