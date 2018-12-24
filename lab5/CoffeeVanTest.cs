namespace lab5
{
    using System;
    using NUnit.Framework;
    /// <summary>
    /// Tests CoffeeVan
    /// </summary>
    ///
    [TestFixture]
    public class CoffeeVanTest
    {
        private CoffeeVan coffeeVan;
        private Coffee coffeeGrain;
        private Coffee coffeeGround;
        private Coffee coffeeSoluble;

        /// <summary>
        /// Initializes CoffeeVan test objects
        /// </summary>
        /// 
        [SetUp]
        protected void SetUp()
        {
            coffeeGrain = new Coffee(CoffeeType.Grain, 1);
            coffeeGround = new Coffee(CoffeeType.Ground, 12);
            coffeeSoluble = new Coffee(CoffeeType.Soluble, 4);
        }

        /// <summary>
		/// Assert that Sort is correct
		/// </summary>
        ///
        [Test]
        public void SortTest()
        {
            var maxWeight = 10124;
            coffeeVan = new CoffeeVan(maxWeight);
            coffeeVan.AddProduct(coffeeSoluble);
            coffeeVan.AddProduct(coffeeGrain);
            coffeeVan.AddProduct(coffeeGround);

            coffeeVan.SortProducts();
            Assert.IsTrue((coffeeVan.products[0] as Coffee).type.Equals(CoffeeType.Grain));
        }

        /// <summary>
		/// Assert that PackIn is correct
		/// </summary>
        ///
        [Test]
        public void PackInTest()
        {
            CoffeePackage package = new CoffeePackage(PackageType.Jar);
            coffeeGrain.PackIn(package);

            Assert.IsTrue(coffeeGrain.package.weight.Equals((double)PackageType.Jar));
        }

        /// <summary>
		/// Assert that Gross is correct
		/// </summary>
        ///
        [Test]
        public void GrossTest()
        {
            var netWeight = 10;
            Coffee coffee = new Coffee(CoffeeType.Grain, netWeight);
            CoffeePackage package = new CoffeePackage(PackageType.Jar);
            coffee.PackIn(package);

            Assert.IsTrue(coffee.grossWeight.Equals((double)PackageType.Jar + netWeight));
        }

    }
}