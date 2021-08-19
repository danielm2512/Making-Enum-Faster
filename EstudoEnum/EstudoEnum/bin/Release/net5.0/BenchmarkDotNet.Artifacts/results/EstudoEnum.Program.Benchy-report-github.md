``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i5-4460 CPU 3.20GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
.NET SDK=5.0.301
  [Host]     : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT


```
|       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
|------------- |----------:|----------:|----------:|-------:|----------:|
| NativeString | 35.029 ns | 0.5616 ns | 0.5253 ns | 0.0076 |      24 B |
| FastToString |  1.951 ns | 0.0567 ns | 0.0530 ns |      - |         - |
