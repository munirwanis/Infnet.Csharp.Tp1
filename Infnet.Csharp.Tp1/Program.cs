using System;
using System.Diagnostics;

namespace Infnet.Csharp.Tp1
{
    class MainClass
    {
        private static ISort sort = new BubbleSort();
        private static Stopwatch stopwatch = new Stopwatch();

        public static void Main(string[] args)
        {
            try
            {
                RunArraySort(100);

                RunArraySort(1000);

                RunArraySort(10000);

                RunArraySort(100000);

                RunArraySort(1000000);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ocorreu um erro: {ex}");
            }
        }

        public static void RunArraySort(int length)
        {
            var array = ArrayGenerator.Generate(length);
            Debug.WriteLine($"Array de {length} posições");
            Debug.WriteLine(string.Join(",", array));
            stopwatch.Start();
            sort.Sort(array);
            stopwatch.Stop();
            Debug.WriteLine(string.Join(",", array));
            Debug.WriteLine($"Levou {stopwatch.ElapsedMilliseconds} ms para se ordenar.");
            Debug.WriteLine($"{Environment.NewLine}");
        }
    }
}
