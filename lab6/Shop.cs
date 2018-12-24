namespace lab6
{
    public class Shop
    {
        public string[] departments { get; internal set; }
        public string[] products { get; internal set; }
        public string[] services { get; internal set; }

        public class ShopBuilder
        {
            private Shop shop;
            public ShopBuilder init()
            {
                shop = new Shop();

                return this;
            }

            public ShopBuilder Departments(string[] departments)
            {
                shop.departments = departments;

                return this;
            }

            public ShopBuilder Products(string[] items)
            {
                shop.products = items;

                return this;
            }

            public ShopBuilder Services(string[] items)
            {
                shop.services = items;

                return this;
            }

            public Shop Build() {
                return this.shop;
            }

        }

        Shop() { }

    }
}