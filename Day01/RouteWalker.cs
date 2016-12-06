using System;
using System.Collections.Generic;

namespace Day01
{
    public class RouteWalker
    {
        public int XCoordinate { get; private set; }

        public int YCoordinate { get; private set; }

        public List<RouteLink> Links { get; } = new List<RouteLink>();

        private Direction _direction = Direction.Up;

        public void Walk(IEnumerable<RouteStep> steps)
        {
            foreach (var routeStep in steps)
            {
                ProcessStep(routeStep);
            }
        }

        private void ProcessStep(RouteStep routeStep)
        {
            // change direction
            DoTurn(routeStep);

            // walk distance
            DoWalk(routeStep);
        }

        protected virtual void DoTurn(RouteStep routeStep)
        {
            switch (_direction)
            {
                case Direction.Up:
                    _direction = routeStep.Direction == RouteDirection.Left ? Direction.Left : Direction.Right;
                    break;
                case Direction.Down:
                    _direction = routeStep.Direction == RouteDirection.Left ? Direction.Right : Direction.Left;
                    break;
                case Direction.Left:
                    _direction = routeStep.Direction == RouteDirection.Left ? Direction.Down : Direction.Up;
                    break;
                case Direction.Right:
                    _direction = routeStep.Direction == RouteDirection.Left ? Direction.Up : Direction.Down;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected virtual void DoWalk(RouteStep routeStep)
        {
            var currentCoordinates = new RoutePoint(XCoordinate, YCoordinate);

            switch (_direction)
            {
                case Direction.Up:
                    YCoordinate += routeStep.Distance;
                    break;
                case Direction.Down:
                    YCoordinate -= routeStep.Distance;
                    break;
                case Direction.Left:
                    XCoordinate -= routeStep.Distance;
                    break;
                case Direction.Right:
                    XCoordinate += routeStep.Distance;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var newCoordinates = new RoutePoint(XCoordinate, YCoordinate);
            Links.Add(new RouteLink(currentCoordinates, newCoordinates));
        }
    }
}
