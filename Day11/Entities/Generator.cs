using System.Diagnostics;

namespace Day11.Entities
{
    [DebuggerStepThrough]
    public class Generator
    {
        public Material Material { get; }

        public Generator(Material material)
        {
            Material = material;
        }

        protected bool Equals(Generator other)
        {
            return Material == other.Material;
        }

        public override bool Equals(object obj)
        {
            return Equals((Generator) obj);
        }

        public override int GetHashCode()
        {
            return (int) Material;
        }

        public override string ToString()
        {
            return $"Generator {Material}";
        }
    }
}
