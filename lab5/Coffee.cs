using System;

namespace lab5
{
    public enum CoffeeType
    {
        /// price per unit mass 
        Grain = 21, Ground = 42, Soluble = 124
    }
    public class Coffee : IWithPackage, IComparable
    {

        public CoffeeType type { get; }
        private int weight;
        private CoffeePackage coffeePackage = new CoffeePackage(PackageType.Jar);
        public CoffeePackage package
        {
            get
            {
                return this.coffeePackage;
            }
        }

        public double grossWeight
        {
            get
            {
                return this.weight + this.package.weight;
            }
        }
        public double netWeight
        {
            get
            {
                return this.weight;
            }
        }

        public double price
        {
            get
            {
                return (double)this.type * this.weight;
            }
        }

        public Coffee(CoffeeType type, int weight)
        {
            this.type = type;
            this.weight = weight;
        }

        public void PackIn(CoffeePackage package)
        {
            coffeePackage = package;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Coffee otherCoffee = obj as Coffee;
            if (otherCoffee != null)
            {
                if (this.price == otherCoffee.price)
                {
                    return this.grossWeight.CompareTo(otherCoffee.grossWeight);
                }

                return this.price.CompareTo(otherCoffee.price);
            }
            else
                throw new ArgumentException("Object is not a Coffee");
        }
    }
}