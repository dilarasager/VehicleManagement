using Model;
using Model.Base;

namespace Interface
{
    public interface IVehicleRepository
    {
        IEnumerable<Car> GetCarsByColor(string color);

        IEnumerable<Bus> GetBusesByColor(string color);

        IEnumerable<Boat> GetBoatsByColor(string color);

        void TurnOnOffCarHeadlights(int carId, bool on);

        void DeleteCar(int carId);
    }
}