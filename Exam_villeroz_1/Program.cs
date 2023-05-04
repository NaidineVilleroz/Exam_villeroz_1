
class Car
{
    public string Brand { get; set; }
    public int Price { get; set; }

    public Car(string brand, int price)
    {
        Brand = brand;
        Price = price;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        cars.Add(new Car("Honda", 1150000));
        cars.Add(new Car("Toyota", 1250000));
        cars.Add(new Car("Geely", 1300000));
        cars.Add(new Car("Nissan", 1500000));
        cars.Add(new Car("Ford", 2500000));
        cars.Add(new Car("Kia", 1100000));
        cars.Add(new Car("Chevrolet", 1800000));
        cars.Add(new Car("Hyundai", 1600000));
        cars.Add(new Car("Subaru", 2000000));
        cars.Add(new Car("Mitsubishi", 1400000));


        var filteredCars = cars.Where(car => car.Price >= 1000000);

        var groupedCars = filteredCars.GroupBy(car => car.Brand);

        foreach (var group in groupedCars)
        {
            Console.WriteLine("=== " + group.Key + " ===");

            foreach (var car in group)
            {
                if (car.Price > 1200000)
                {
                    Console.WriteLine(car.Brand + " - this belongs to class A car");
                }
                else
                {
                    Console.WriteLine(car.Brand + " - this belongs to class B car");
                }
            }

            Console.WriteLine();
        }
    }
}
