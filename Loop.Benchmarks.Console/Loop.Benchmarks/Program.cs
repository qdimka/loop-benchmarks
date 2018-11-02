using System;
using BenchmarkDotNet.Running;
using Loop.Benchmarks.BenchMarks;

namespace Loop.Benchmarks
{
	class Program
	{
		static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run<LoopBenchmark>();
		}
	}
}