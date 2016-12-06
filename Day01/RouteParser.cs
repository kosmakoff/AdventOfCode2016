using System.Collections.Generic;
using System.Linq;

namespace Day01
{
    public class RouteParser
    {
        public IEnumerable<RouteStep> GetSteps(string route)
        {
            return route.Split(',').Select(s => s.Trim()).Select(RouteStep.Parse);
        }
    }
}
