using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using Treap;

namespace TreapTest
{
    [MemoryDiagnoser]
    public class TreapDataStructure
    {
        private static IEnumerable<int> GetRandomNumbers(int count)
        {
            var randomNumbers = new HashSet<int>();

            var random = new Random();
            for (int i = 0; i < count; i++)
            {
                while (!randomNumbers.Add(random.Next()))
                {
                }
            }

            return randomNumbers;
        }
        
        [Benchmark]
        public void TreapNode_Add()
        {
            var treapNode = new Node(1, 1);
            foreach (var item in GetRandomNumbers(1000))
            {
                treapNode.Add(item);
            }
        }
        
        [Benchmark]
        public void TreapNode_Delete()
        {
            var treapNode = new Node(1, 1);

            treapNode.Remove(1);
        }
    }
}