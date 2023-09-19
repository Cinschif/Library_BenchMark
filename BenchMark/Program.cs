using BenchmarkDotNet.Running;
using Library;

namespace BenchMark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchMarkTest>();
        }
    }
}