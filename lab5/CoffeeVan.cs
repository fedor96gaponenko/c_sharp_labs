using System;
using System.Collections;

namespace lab5
{
    public class CoffeeVan
    {
        private double maxWeight { get; }
        public ArrayList products { get; }
        public double weight
        {
            get
            {
                double weight = 0;
                foreach (Coffee product in this.products)
                {
                    weight += product.grossWeight;
                }

                return weight;
            }
        }

        public CoffeeVan(double maxWeight)
        {
            this.maxWeight = maxWeight;
            products = new ArrayList();
        }

        public void AddProduct(Coffee product)
        {
            if (maxWeight >= this.weight + product.grossWeight)
            {
                this.products.Add(product);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void SortProducts()
        {
            products.Sort();
        }
    }
}