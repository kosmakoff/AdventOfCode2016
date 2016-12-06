using System;
using System.Text.RegularExpressions;

namespace Day01
{
    public class RouteStep
    {
        public RouteDirection Direction { get; }

        public int Distance { get; }

        public RouteStep(RouteDirection direction, int distance)
        {
            Direction = direction;
            Distance = distance;
        }

        private static readonly Regex StepRegex = new Regex(@"^(R|L)(\d+)$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public static RouteStep Parse(string routeStep)
        {
            var match = StepRegex.Match(routeStep);
            if (!match.Success)
                throw new FormatException($"RouteStep '{routeStep}' was in incorrect format.");

            var directionString = match.Groups[1].Value;
            var distanceString = match.Groups[2].Value;

            RouteDirection direction;

            switch (directionString.ToUpperInvariant())
            {
                case "L":
                    direction = RouteDirection.Left;
                    break;

                case "R":
                    direction = RouteDirection.Right;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(directionString), directionString, "Invalid direction string.");
            }

            int distance = int.Parse(distanceString);

            return new RouteStep(direction, distance);
        }
    }
}