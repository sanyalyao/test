using Homework8.Task_2.BaseObjects;

namespace Homework8.Task_2.Products
{
    class Cheese : Product
    {
        public Cheese(string name, int price, DateTime createdDate, DateTime expirationDate) : base(name, price, createdDate, expirationDate)
        {
        }
    }
}
