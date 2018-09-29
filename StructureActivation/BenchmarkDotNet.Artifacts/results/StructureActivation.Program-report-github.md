``` ini

BenchmarkDotNet=v0.11.1, OS=Windows 10.0.17134.285 (1803/April2018Update/Redstone4), VM=Hyper-V
Unknown processor
.NET Core SDK=2.1.402
  [Host]     : .NET Core 2.1.4 (CoreCLR 4.6.26814.03, CoreFX 4.6.26814.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.4 (CoreCLR 4.6.26814.03, CoreFX 4.6.26814.02), 64bit RyuJIT


```
|             Method |     Mean |     Error |    StdDev | Scaled |
|------------------- |---------:|----------:|----------:|-------:|
|          Activated | 4.717 ns | 0.0228 ns | 0.0213 ns |   1.00 |
| ActivatedWithStore | 3.322 ns | 0.0226 ns | 0.0211 ns |   0.70 |
