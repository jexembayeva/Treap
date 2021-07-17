namespace TreapTest
{
    class Program
    {
        static void Main(string[] args)
        { 
            BenchmarkDotNet.Running.BenchmarkRunner.Run<TreapDataStructure>();
        }
    }
}