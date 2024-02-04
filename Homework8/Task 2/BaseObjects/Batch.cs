namespace Homework8.Task_2.BaseObjects
{
    class Batch : Product
    {
        private int CountItems { get; set; }

        public Batch(string name, int price, int countItems, DateTime createdDate, DateTime expirationDate) : base(name, price, createdDate, expirationDate)
        {
            CountItems = countItems;
        }

        public override void ShowFullInformation()
        {
            Console.WriteLine($"Batch name: {Name}\n" +
                $"Price: {Price}\n" +
                $"number of items: {CountItems}\n" +
                $"Created date: {CreatedDate}\n" +
                $"Expiration date: {ExpirationDate}");
        }

        public new void ValidExpirationDate()
        {
            if (base.ValidExpirationDate())
                Console.WriteLine("Batch is not spoiled");
            else
                Console.WriteLine("Batch is spoiled");
        }
    }
}
