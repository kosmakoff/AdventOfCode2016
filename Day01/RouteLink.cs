using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day01
{
    public class RouteLink
    {
        public RoutePoint Start { get; }

        public RoutePoint Finish { get; }

        public RouteLink(RoutePoint start, RoutePoint finish)
        {
            if (start.X != finish.X && start.Y != finish.Y)
                throw new ArgumentException("Must be strictly horizontal or vertical link.");

            if (start.Equals(finish))
                throw new ArgumentException("Must not be same points.");

            Start = start;
            Finish = finish;
        }

        public bool IsHorizontal => Start.Y == Finish.Y;

        public bool IsVertical => Start.X == Finish.X;
    }
}
