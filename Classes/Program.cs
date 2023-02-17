namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();  // the constructor
            myCar.Make = "Chevy";
            myCar.Model = "Equinox";
            myCar.Year = 2015;

            var teenCar = new Car()
            {
                Make = "Ford",
                Model = "Focus",
                Year = 2003,
            };

            var wifeCar = new Car("Chevy", "Trailblazer", 2022);

            var carList = new List<Car>() { myCar, teenCar, wifeCar };

            foreach(var car in carList)
            {
                Console.WriteLine($" {car.Year} {car.Make} {car.Model}");
            }

        }
    }
}
