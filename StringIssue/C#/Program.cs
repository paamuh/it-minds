using System;
using System.Linq;

namespace StringIssue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Filling array: ");

            var strs = Enumerable.Range(0, 40000).Select(s => s.ToString());

            Console.WriteLine("Executing inefficient String-Helper method: ");

            var before = DateTime.Now;

            var output = StringHelpers.MergeStrings(strs);
            

            var after = DateTime.Now;

            Console.WriteLine($"Length: {output.Length}");
            Console.WriteLine("Elapsed time: " + (after - before).TotalMilliseconds);

            Console.ReadLine();

            var before1 = DateTime.Now;

            var output1 = StringHelpers.BetterMergeStrings(strs);

            var after1 = DateTime.Now;

            Console.WriteLine($"Lenght: {output1.Length}");
            Console.WriteLine("Elapsed time: " + (after1 - before1).TotalMilliseconds);


            Console.ReadLine();
        }
    }
}
