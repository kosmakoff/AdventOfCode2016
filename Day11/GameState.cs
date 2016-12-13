using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    public class GameState
    {
        public Floor CurrentFloor { get; }

        public IDictionary<Floor, FloorState> FloorStates { get; }

        public GameState(Floor startingFloor, IDictionary<Floor, FloorState> startingFloorStates)
        {
            CurrentFloor = startingFloor;
            FloorStates = new Dictionary<Floor, FloorState>(startingFloorStates);
        }

        public bool IsValid()
        {
            return FloorStates.Values.All(floorState => floorState.IsValid());
        }

        protected bool Equals(GameState other)
        {
            return CurrentFloor == other.CurrentFloor &&
                   FloorStates
                       .Join(other.FloorStates, kvp => kvp.Key, kvp => kvp.Key,
                           (kvp1, kvp2) => kvp1.Value.Equals(kvp2.Value))
                       .All(x => x);
        }

        public override bool Equals(object obj)
        {
            return Equals((GameState) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int) CurrentFloor*397) ^ (FloorStates?.GetHashCode() ?? 0);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append("F=");
            sb.Append((int) CurrentFloor);

            foreach (var kvp in FloorStates.OrderBy(kvp => (int) kvp.Key))
            {
                sb.Append("|");

                sb.Append(kvp.Value.ToString());
            }

            return sb.ToString();
        }
    }
}
