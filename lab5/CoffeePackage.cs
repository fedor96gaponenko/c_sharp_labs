namespace lab5
{

    public enum PackageType
    {
        /// weight
        Jar = 5, Package = 1
    }

    public class CoffeePackage
    {
        PackageType type { get; }
        public double weight { get; }

        public CoffeePackage(PackageType type)
        {
            this.type = type;
            this.weight = (double)type;
        }
    }
}