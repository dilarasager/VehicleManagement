using Interface;
using Model;

namespace Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly List<Car> cars;
        private readonly List<Bus> buses;
        private readonly List<Boat> boats;

        public VehicleRepository()
        {
            cars = new List<Car>
        {
            new Car { ID = 1, Color = "red", Wheels = 4, Headlights = false },
            new Car { ID = 2, Color = "blue", Wheels = 4, Headlights = true },
            new Car { ID = 3, Color = "white", Wheels = 4, Headlights = true },
            new Car { ID = 4, Color = "black", Wheels = 4, Headlights = true },
            // Add more cars...
        };

            buses = new List<Bus>
        {
            new Bus { ID = 1, Color = "red" },
            new Bus { ID = 2, Color = "black" },
            new Bus { ID = 3, Color = "white" },
            // Add more buses...
        };

            boats = new List<Boat>
        {
            new Boat { ID = 1, Color = "blue" },
            new Boat { ID = 2, Color = "white" },
            new Boat { ID = 3, Color = "yellow" },
            // Add more boats...
        };
        }

        public IEnumerable<Car> GetCarsByColor(string color)
        {
            return cars.Where(car => car.Color.Equals(color, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Bus> GetBusesByColor(string color)
        {
            return buses.Where(bus => bus.Color.Equals(color, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Boat> GetBoatsByColor(string color)
        {
            return boats.Where(boat => boat.Color.Equals(color, StringComparison.OrdinalIgnoreCase));
        }

        public void TurnOnOffCarHeadlights(int carId, bool on)
        {
            var car = cars.FirstOrDefault(c => c.ID == carId);
            if (car != null)
            {
                car.Headlights = on;
            }
        }

        public void DeleteCar(int carId)
        {
            var car = cars.FirstOrDefault(c => c.ID == carId);
            if (car != null)
            {
                cars.Remove(car);
            }
        }
    }
}