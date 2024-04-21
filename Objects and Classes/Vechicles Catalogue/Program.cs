using System.Reflection;

namespace Vechicles_Catalogue
{   

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; } 
        public int HorsePower { get; set; } 
    }

    public class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; } 

        public int Weigth { get; set; } 
    }

    public class Catalogue
    {
        public List<Car> Cars=new List<Car>();

        public List<Truck> Trucks { get; set; }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Catalogue catalogue = new Catalogue()
            {
                Cars = new List<Car>(),
                Trucks = new List<Truck>()
            };
            
            while (input != "end")
            {
                string[] information = input.Split("/");
                string type = information[0];
                string brand = information[1];
                string model = information[2];

                if (type == "Car")
                {
                    int horsePower = int.Parse(information[3]);

                    Car currentCar = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower,
                    };
                    catalogue.Cars.Add(currentCar);
                }

                else if (type == "Truck")
                {
                    int wiegth = int.Parse(information[3]);

                    Truck currentTruck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weigth = wiegth,
                    };
                    catalogue.Trucks.Add(currentTruck);
                }
                input = Console.ReadLine();
            }

            if(catalogue.Cars.Count>0 )
            {
                List<Car> alphaCars = catalogue.Cars.OrderBy(c => c.Brand).ToList();
                Console.WriteLine($"Cars:");
                foreach ( Car car in alphaCars )
                {
                    Console.WriteLine($"{car.Brand}: {car.Model}- {car.HorsePower}hp");
                }
            }
            if(catalogue.Trucks.Count>0 )
            {
                List<Truck> alphaTrucks = catalogue.Trucks.OrderBy(c => c.Brand).ToList();
                Console.WriteLine($"Trucks:");
                foreach ( Truck truck in alphaTrucks )
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model}- {truck.Weigth}kg");
                }
            }        

            
        }
    }
}
