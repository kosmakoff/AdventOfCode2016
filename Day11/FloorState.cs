using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day11.Entities;

namespace Day11
{
    public class FloorState
    {
        public ICollection<Generator> Generators { get; }

        public ICollection<Microchip> Microchips { get; }

        public FloorState()
        {
            Generators = new HashSet<Generator>();
            Microchips = new HashSet<Microchip>();
        }

        public FloorState(IEnumerable<Generator> generators, IEnumerable<Microchip> microchips)
        {
            Generators = new HashSet<Generator>(generators);
            Microchips = new HashSet<Microchip>(microchips);
        }

        protected bool Equals(FloorState other)
        {
            return Generators.OrderBy(x => x.Material).SequenceEqual(other.Generators.OrderBy(x => x.Material)) &&
                   Microchips.OrderBy(x => x.Material).SequenceEqual(other.Microchips.OrderBy(x => x.Material));
        }

        public override bool Equals(object obj)
        {
            return Equals((FloorState) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Generators?.GetHashCode() ?? 0)*397) ^ (Microchips?.GetHashCode() ?? 0);
            }
        }

        public bool IsValid()
        {
            var commonMaterials = Generators
                .Join(Microchips, gen => gen.Material, chip => chip.Material, (gen, chip) => gen.Material)
                .ToList();

            var extraGenerators = Generators.Select(gen => gen.Material).Except(commonMaterials);
            var extraMicrochips = Microchips.Select(chip => chip.Material).Except(commonMaterials);

            // is is valid if there are no generators except covered by chip, or no extra chips except covered by generators

            return !extraGenerators.Any() || !extraMicrochips.Any();
        }

        public override string ToString()
        {
            var names = new List<string>(10);

            foreach (var generator in Generators.OrderBy(g => (int)g.Material))
            {
                names.Add($"{generator.Material.ToString().Substring(0, 2)}G");
            }

            foreach (var microchip in Microchips.OrderBy(g => (int)g.Material))
            {
                names.Add($"{microchip.Material.ToString().Substring(0, 2)}M");
            }

            return names.Any() ? string.Join(",", names) : "-";
        }
    }
}
