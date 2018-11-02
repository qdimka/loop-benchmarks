using BenchmarkDotNet.Attributes;

namespace Loop.Benchmarks.BenchMarks
{
	[ClrJob]
	[RPlotExporter, RankColumn]
	public class LoopBenchmark
	{
		public const int N = 10000;
		
		[Benchmark]
		public int ForForWard()
		{
			int sum=0;
			for (int i = 0; i < N; i++)
			{
				sum++;
			}

			return sum;
		}

		[Benchmark]
		public int ForBackWard()
		{
			int sum = 0;
			for (int i = N; i > 0; i--)
			{
				sum++;
			}
			
			return sum;
		}

		[Benchmark]
		public int WhileForWard()
		{
			int sum=0;
			int i = 0;

			while (i++ < N)
			{
				sum++;
			}

			return sum;
		}
		
		[Benchmark]
		public int WhileBackWard()
		{
			int sum=0;
			int i = N;

			while (i-- > 0)
			{
				sum++;
			}

			return sum;
		}
	}
}