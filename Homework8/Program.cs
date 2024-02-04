using Homework8.Task_1.Figures;
using Homework8.Task_2.BaseObjects;
using Homework8.Task_2.Products;

namespace Homework8
{
    class Programm
    {
        static void Main()
        {            
            Task1();
            Task2();
        }

        private static void Task1()
        {
            var figures = new BaseFigure[]
            {
                new Triangle(5,5,5),
                new Rectangle(4,8),
                new Circle(7),
                new Rectangle(7,9),
                new Circle(3),
            };

            figures.ToList().ForEach(figure => Console.WriteLine($"{figure.GetType().Name} perimeter = {figure.MeasurePerimeter()}"));
            figures.ToList().ForEach(figure => Console.WriteLine($"{figure.GetType().Name} area = {figure.MeasureArea()}"));
        }

        private static void Task2()
        {
            var listOfProducts = new List<Product>()
            {
                new Yogurt("Strawberry yogurt", 35, DateTime.Now.AddDays(-4), DateTime.Now.AddDays(-1)),
                new Milk("Milk", 80, DateTime.Now.AddDays(-4), DateTime.Now.AddDays(2)),
                new Cheese("German cheese", 200, DateTime.Now.AddDays(-7), DateTime.Now.AddDays(1)),
                new Cheese("10 eggs", 100, DateTime.Now.AddDays(-27), DateTime.Now.AddDays(-2)),
            };            
            var productsKit = new Kit("First Kit", listOfProducts.Sum(product => product.Price), listOfProducts);
            var productsBatch = new Batch("First Batch", listOfProducts.Sum(product => product.Price), listOfProducts.Count, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(1));

            productsKit.ShowFullInformation();
            Console.WriteLine("___________________________________________");
            productsBatch.ShowFullInformation();
            Console.WriteLine("___________________________________________");
            Console.WriteLine("Spoiled products:");
            listOfProducts.ForEach(product => 
            {
                if (!product.ValidExpirationDate())
                    Console.WriteLine($"{product.Name} is spoiled");
            });
        }

        private static void Task3()
        {

        }
    }
}