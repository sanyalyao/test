namespace Homework8.Task_2.BaseObjects
{
    class Kit : Product
    {
        private List<Product> Products { get; set; }

        public Kit(string name, int price, List<Product> products) : base(name, price)
        {
            Products = products;
        }

        public override void ShowFullInformation()
        {
            Console.WriteLine($"Kit name: {Name}");
            Console.WriteLine($"Kit price: {Price}");
            Console.WriteLine("List of products:");
            Products.ForEach(product => Console.WriteLine(product.Name));
        }
    }
}
