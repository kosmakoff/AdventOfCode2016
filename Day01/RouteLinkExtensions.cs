namespace Day01
{
    public static class RouteLinkExtensions
    {
        public static RoutePoint FindIntersection(this RouteLink firstLink, RouteLink secondLink)
        {
            if (firstLink.IsHorizontal && secondLink.IsHorizontal || firstLink.IsVertical && secondLink.IsVertical)
                return null;

            var horizontalLink = firstLink.IsHorizontal ? firstLink : secondLink;
            var verticalLink = firstLink.IsVertical ? firstLink : secondLink;

            if (horizontalLink.Start.Y.IsBetween(verticalLink.Start.Y, verticalLink.Finish.Y) && verticalLink.Start.X.IsBetween(horizontalLink.Start.X, horizontalLink.Finish.X))
            {
                return new RoutePoint(verticalLink.Start.X, horizontalLink.Start.Y);
            }
            else
            {
                return null;
            }
        }

        private static bool IsBetween(this int coord, int otherCoord1, int otherCoord2)
        {
            var min = otherCoord1 > otherCoord2 ? otherCoord2 : otherCoord1;
            var max = otherCoord1 < otherCoord2 ? otherCoord2 : otherCoord1;

            return coord > min && coord < max;
        }
    }
}
