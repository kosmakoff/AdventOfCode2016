namespace Day11.Entities
{
    public class Microchip
    {
        public Material Material { get; }

        public Microchip(Material material)
        {
            Material = material;
        }

        protected bool Equals(Microchip other)
        {
            return Material == other.Material;
        }

        public override bool Equals(object obj)
        {
            return Equals((Microchip) obj);
        }

        public override int GetHashCode()
        {
            return (int) Material;
        }

        public override string ToString()
        {
            return $"Microchip {Material}";
        }
    }
}
