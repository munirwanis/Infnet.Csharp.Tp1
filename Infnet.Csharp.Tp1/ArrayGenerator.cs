using System;
using System.Linq;

namespace Infnet.Csharp.Tp1
{
    public static class ArrayGenerator
    {
        public static int[] Generate(int length) 
        {
            var random = new Random();
            int[] generatedArray = Enumerable
                .Repeat(0, length)
                .Select(i => random.Next(length))
                .ToArray();
            return generatedArray;
        }
    }
}
