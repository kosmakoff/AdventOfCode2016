using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day11.Entities;

namespace Day11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Advent Of Code 2016, day 11");

            // starting state

            //var startingGameState = CreateStartingGameState();
            //var endingGameState = CreateEndingGameState();

            var startingGameState = CreateDemoStartState();
            var endingGameState = CreateDemoEndState();

            IList<GameState> finalStateList = null;
            var gameStates = new List<GameState> {startingGameState};

            foreach (var stateList in ListStateTransitions(gameStates))
            {
                Console.WriteLine($"{stateList.Count}\n{string.Join("\n", stateList)}\n");

                if (stateList.Last().Equals(endingGameState))
                {
                    finalStateList = stateList;
                    break;
                }
            }

            if (finalStateList != null)
                Console.WriteLine($"Count = {finalStateList.Count}");
        }

        private static IEnumerable<IList<GameState>> ListStateTransitions(IList<GameState> currentStates)
        {
            var lastState = currentStates.Last();

            var currentFloor = lastState.CurrentFloor;

            var statesList = new List<IList<GameState>>();

            foreach (var nextFloor in ListAdjacentFloors(currentFloor))
            {
                var floorStateCurrent = lastState.FloorStates[currentFloor];
                var floorStateNext = lastState.FloorStates[nextFloor];

                foreach (var stateTuple in ListAdjacentFloorStates(floorStateCurrent, floorStateNext))
                {
                    var newCurrent = stateTuple.Item1;
                    var newNext = stateTuple.Item2;

                    var newFloorStates = new Dictionary<Floor, FloorState>(lastState.FloorStates)
                    {
                        [currentFloor] = newCurrent,
                        [nextFloor] = newNext
                    };

                    var newState = new GameState(nextFloor, newFloorStates);

                    // skip if next state is not valid
                    if (!newState.IsValid())
                        continue;

                    // skip if next state repeats any of previous states
                    if (currentStates.Any(state => state.Equals(newState)))
                        continue;

                    var newStatesList = new List<GameState>(currentStates) {newState};
                    statesList.Add(newStatesList);

                    yield return new List<GameState>(newStatesList);
                }
            }

            // finally, recursively go through all possible transitions from the newly generated states
            foreach (var stateList in statesList)
            {
                foreach (var gameStates in ListStateTransitions(stateList))
                {
                    yield return gameStates;
                }
            }
        }

        private static IEnumerable<Floor> ListAdjacentFloors(Floor floor)
        {
            switch (floor)
            {
                case Floor.Floor1:
                    yield return Floor.Floor2;
                    break;
                case Floor.Floor2:
                    yield return Floor.Floor1;
                    yield return Floor.Floor3;
                    break;
                case Floor.Floor3:
                    yield return Floor.Floor2;
                    yield return Floor.Floor4;
                    break;
                case Floor.Floor4:
                    yield return Floor.Floor3;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(floor), floor, null);
            }
        }

        /// <summary>
        /// Enumerates through all possible transitions that can happen between 2 adjacent floors
        /// </summary>
        /// <param name="floorStateCurrent">Current floor</param>
        /// <param name="floorStateNext">Adjacent/next floor</param>
        /// <returns></returns>
        private static IEnumerable<Tuple<FloorState, FloorState>> ListAdjacentFloorStates(FloorState floorStateCurrent, FloorState floorStateNext)
        {
            // list all items
            var allItems = floorStateCurrent.Generators.Cast<object>().Concat(floorStateCurrent.Microchips.Cast<object>()).ToList();

            // build singles
            foreach (var item in allItems)
            {
                yield return ComputeItemMove(floorStateCurrent, floorStateNext, new[] {item});
            }

            // build pairs
            for (int leftIndex = 0; leftIndex < allItems.Count - 1; leftIndex++)
            {
                for (int rightIndex = leftIndex + 1; rightIndex < allItems.Count; rightIndex++)
                {
                    var left = allItems[leftIndex];
                    var right = allItems[rightIndex];

                    yield return ComputeItemMove(floorStateCurrent, floorStateNext, new[] {left, right});
                }
            }
        }

        private static Tuple<FloorState, FloorState> ComputeItemMove(FloorState floorStateCurrent, FloorState floorStateNext, object[] items)
        {
            var generatorsToMove = items.OfType<Generator>().ToList();
            var microchipsToMove = items.OfType<Microchip>().ToList();

            var newCurrent = new FloorState(floorStateCurrent.Generators.Except(generatorsToMove), floorStateCurrent.Microchips.Except(microchipsToMove));
            var newNext = new FloorState(floorStateNext.Generators.Concat(generatorsToMove), floorStateNext.Microchips.Concat(microchipsToMove));

            return new Tuple<FloorState, FloorState>(newCurrent, newNext);
        }

        private static GameState CreateDemoStartState()
        {
            return new GameState(Floor.Floor1, new Dictionary<Floor, FloorState>
            {
                [Floor.Floor1] = new FloorState
                {
                    Microchips =
                    {
                        new Microchip(Material.Hydrogen),
                        new Microchip(Material.Lithium)
                    }
                },
                [Floor.Floor2] = new FloorState
                {
                    Generators =
                    {
                        new Generator(Material.Hydrogen)
                    }
                },
                [Floor.Floor3] = new FloorState
                {
                    Generators =
                    {
                        new Generator(Material.Lithium)
                    }
                },
                [Floor.Floor4] = new FloorState()
            });
        }

        private static GameState CreateDemoEndState()
        {
            return new GameState(Floor.Floor4, new Dictionary<Floor, FloorState>
            {
                [Floor.Floor1] = new FloorState(),
                [Floor.Floor2] = new FloorState(),
                [Floor.Floor3] = new FloorState(),
                [Floor.Floor4] = new FloorState
                {
                    Generators =
                    {
                        new Generator(Material.Hydrogen),
                        new Generator(Material.Lithium)
                    },
                    Microchips =
                    {
                        new Microchip(Material.Hydrogen),
                        new Microchip(Material.Lithium)
                    }
                }
            });
        }

        private static GameState CreateStartingGameState()
        {
            return new GameState(Floor.Floor1, new Dictionary<Floor, FloorState>
            {
                [Floor.Floor1] = new FloorState
                {
                    Generators =
                    {
                        new Generator(Material.Thulium),
                        new Generator(Material.Plutonium),
                        new Generator(Material.Strontium)
                    },
                    Microchips =
                    {
                        new Microchip(Material.Thulium)
                    }
                },
                [Floor.Floor2] = new FloorState
                {
                    Generators = {},
                    Microchips =
                    {
                        new Microchip(Material.Plutonium),
                        new Microchip(Material.Strontium)
                    }
                },
                [Floor.Floor3] = new FloorState
                {
                    Generators =
                    {
                        new Generator(Material.Promethium),
                        new Generator(Material.Ruthenium)
                    },
                    Microchips =
                    {
                        new Microchip(Material.Promethium),
                        new Microchip(Material.Ruthenium)
                    }
                },
                [Floor.Floor4] = new FloorState()
            });
        }

        private static GameState CreateEndingGameState()
        {
            return new GameState(Floor.Floor4, new Dictionary<Floor, FloorState>
            {
                [Floor.Floor1] = new FloorState(),
                [Floor.Floor2] = new FloorState(),
                [Floor.Floor3] = new FloorState(),
                [Floor.Floor4] = new FloorState
                {
                    Generators =
                    {
                        new Generator(Material.Thulium),
                        new Generator(Material.Plutonium),
                        new Generator(Material.Strontium),
                        new Generator(Material.Promethium),
                        new Generator(Material.Ruthenium)
                    },
                    Microchips =
                    {
                        new Microchip(Material.Thulium),
                        new Microchip(Material.Plutonium),
                        new Microchip(Material.Strontium),
                        new Microchip(Material.Promethium),
                        new Microchip(Material.Ruthenium)
                    }
                }
            });
        }
    }
}
