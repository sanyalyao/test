namespace Homework8.Task_2.BaseObjects
{
    public abstract class Product
    {
        public string Name { get ; set ; }
        public int Price { get ; set ; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime ExpirationDate { get ; set; }

        protected Product(string name, int price, DateTime createdDate, DateTime expirationDate) 
        {
            Name = name;
            Price = price; 
            CreatedDate = createdDate;
            ExpirationDate = expirationDate;
        }

        protected Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public virtual void ShowFullInformation()
        {
            Console.WriteLine($"Product name: {Name}\n" +
                $"Price: {Price}\n" +
                $"Created date: {CreatedDate}\n" +
                $"Expiration date: {ExpirationDate}");
        }

        protected void ShowProductName()
        {
            Console.WriteLine($"Product name: {Name}");
        }

        protected void ShowProductPrice()
        {
            Console.WriteLine($"Product price: {Price}");
        }

        protected void ShowProductCreatedDate()
        {
            Console.WriteLine($"Product created date: {CreatedDate}");
        }

        protected void ShowProductExpirationDate()
        {
            Console.WriteLine($"Product expiration date: {ExpirationDate}");
        }

        public virtual bool ValidExpirationDate()
        {
            return ExpirationDate <= DateTime.Now ? false : true;
        }
    }
}
