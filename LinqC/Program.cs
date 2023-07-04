namespace LinqC;
class Program
{
    static void Main(string[] args)
    {
        //List<Car> cars = new List<Car>
        //{
        //    new Car {Name = "Toyota", color = "Red", Model = "Corolla", Price = 2000000},
        //    new Car {Name = "Toyota", color = "blue", Model = "Camry", Price = 2000500},
        //    new Car {Name = "Ford", color = "White", Model = "Edge", Price = 5000000}
        //};

        //var departmentCars = cars.OrderBy(x => x.Name).Where(x => x.Name)

        //foreach (var item in departmentCars)
        //{
        //    Console.WriteLine("The name of the car is {0}, the model is {1}, the Price is {2} and the color is {3}", item.Name, item.Model, item.Price, item.color);
        //}
        DemoModifiers demo = new DemoModifiers();

        demo.protectedvoidss();

        chef chefs = new chef();
        chefs.protectedvoidss();


        Console.ReadLine();
    }
}

