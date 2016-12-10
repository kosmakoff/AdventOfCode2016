using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Day03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Advent Of Code 2016, day 3");

            var fileName = args[0];

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found");
                return;
            }

            var input = File.ReadAllText(fileName);

            var trianglesData = input
                .Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray())
                .ToList();

            var possibleTrianglesCount = trianglesData.Count(PossibleTriangle);

            Console.WriteLine($"Possible triangles count: {possibleTrianglesCount}");

            var trianglesData2 = trianglesData.Select(x => x[0])
                .Concat(trianglesData.Select(x => x[1]))
                .Concat(trianglesData.Select(x => x[2]))
                .PackBy(3)
                .Select(x => x.ToArray())
                .ToList();

            var possibleTrianglesCount2 = trianglesData2.Count(PossibleTriangle);

            Console.WriteLine($"Possible triangles count 2: {possibleTrianglesCount2}");
        }

        private static bool PossibleTriangle(IEnumerable<int> arg)
        {
            var ints = arg.OrderBy(x => x).ToList();
            return ints[2] < ints[0] + ints[1];
        }
    }
}
