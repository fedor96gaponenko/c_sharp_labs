namespace lab6
{
    using System;
    using NUnit.Framework;
    /// <summary>
    /// Tests Shop
    /// </summary>
    ///
    [TestFixture]
    public class ShopTest
    {
        private Shop.ShopBuilder shopBuilder;
        private string[] departments;
        private string[] products;
        private string[] services;

        /// <summary>
        /// Initializes Shop test objects
        /// </summary>
        /// 
        [SetUp]
        protected void SetUp()
        {
            departments = new string[] { "Building", "Culinary" };
            products = new string[] { "Coffee", "Nails" };
            services = new string[] { "Credit", "Delivery" };

            shopBuilder = new Shop.ShopBuilder();
        }

        /// <summary>
		/// Assert that Builder is correct
		/// </summary>
        ///
        [Test]
        public void ShopBuilderTest()
        {
            var shop = shopBuilder
            .init()
            .Departments(departments)
            .Build();

            Assert.IsTrue(shop.departments.Equals(departments));
        }

        /// <summary>
		/// Assert that Builder keeps Shop's state
		/// </summary>
        ///
        [Test]
        public void KeepShopStateTest()
        {
            shopBuilder
            .init()
            .Departments(departments)
            .Build();
            var shop = shopBuilder
            .Products(products)
            .Build();

            Assert.IsTrue(shop.departments.Equals(departments));
            Assert.IsTrue(shop.products.Equals(products));
        }

        /// <summary>
		/// Assert that built Shop is fully initialized
		/// </summary>
        ///
        [Test]
        public void FullyInitializationTest()
        {
            var shop = shopBuilder
            .init()
            .Departments(departments)
            .Products(products)
            .Services(services)
            .Build();

            Assert.IsTrue(shop.departments.Equals(departments));
            Assert.IsTrue(shop.products.Equals(products));
            Assert.IsTrue(shop.services.Equals(services));
        }

    }
}