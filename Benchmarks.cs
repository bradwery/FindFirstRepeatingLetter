using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;

namespace FindFirstRepeatingLetter;

[MemoryDiagnoser(false)]
[Config(typeof(StyleConfig))]
public class Benchmarks
{
    [Benchmark(Baseline = true)]
    public void ListContains()
    {
        FirstRepeatingLetter.ListContains("abcdefghijklmnopqrstuvwxyzz");
    }

    [Benchmark]
    public void ForLoop()
    {
        FirstRepeatingLetter.ForLoop("abcdefghijklmnopqrstuvwxyzz");
    }

    [Benchmark]
    public void BitFlag()
    {
        FirstRepeatingLetter.BitFlag("abcdefghijklmnopqrstuvwxyzz");
    }
}

public class StyleConfig : ManualConfig
{
    public StyleConfig()
    {
        SummaryStyle = SummaryStyle.Default.WithRatioStyle(RatioStyle.Trend);
    }
}