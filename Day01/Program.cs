using System;
using System.Linq;

namespace Day01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Advent Of Code 2016, day 1");

            var input = args[0];

            var routeParser = new RouteParser();
            var steps = routeParser.GetSteps(input).ToArray();

            var walker = new RouteWalker();
            walker.Walk(steps);

            var totalDistance = Math.Abs(walker.XCoordinate) + Math.Abs(walker.YCoordinate);
            Console.WriteLine($"Answer to question 1: {totalDistance}");

            RoutePoint intersection = null;
            for (int i = 4; i <= walker.Links.Count; i++)
            {
                var subList = walker.Links.Take(i).ToList();

                var subject = subList.Last();

                foreach (var routeLink in subList.AsEnumerable().Reverse().Skip(3))
                {
                    intersection = subject.FindIntersection(routeLink);
                    if (intersection != null)
                        break;
                }

                if (intersection != null)
                    break;
            }

            if (intersection != null)
            {
                var intersectionDistance = Math.Abs(intersection.X) + Math.Abs(intersection.Y);
                Console.WriteLine($"Answer to question 2: {intersectionDistance}");
            }
        }
    }
}
