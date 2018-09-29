using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace StructureActivation
{
	public class Program
	{
		static void Main()
		{
			BenchmarkRunner.Run<Program>();
		}

		[Benchmark(Baseline = true)]
		public uint? Activated() => new Structure(100).SomeValue;

		[Benchmark]
		public uint? ActivatedAssignment()
		{
			var selection = new Structure(100);
			return selection.SomeValue;
		}
	}

	public readonly struct Structure
	{
		public Structure(uint? someValue) => SomeValue = someValue;

		public uint? SomeValue { get; }
	}
}