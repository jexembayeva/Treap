``` ini

BenchmarkDotNet=v0.13.0, OS=macOS Big Sur 11.1 (20C69) [Darwin 20.2.0]
Intel Core i5-5250U CPU 1.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.300
  [Host]     : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  DefaultJob : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT


```
|           Method |            Mean |         Error |        StdDev |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |----------------:|--------------:|--------------:|---------:|------:|------:|----------:|
|    TreapNode_Add | 2,523,141.38 ns | 18,801.317 ns | 15,699.952 ns | 289.0625 |     - |     - | 459,033 B |
| TreapNode_Delete |        56.50 ns |      0.394 ns |      0.308 ns |   0.0765 |     - |     - |     120 B |
