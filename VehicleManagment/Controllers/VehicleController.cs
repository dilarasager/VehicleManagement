using Interface;
using Microsoft.AspNetCore.Mvc;

namespace VehicleManagment.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleRepository vehicleRepository;

        public VehiclesController(IVehicleRepository vehicleRepository)
        {
            this.vehicleRepository = vehicleRepository;
        }

        [HttpGet("cars/{color}")]
        public IActionResult GetCarsByColor(string color)
        {
            var cars = vehicleRepository.GetCarsByColor(color);
            return Ok(cars);
        }

        [HttpGet("buses/{color}")]
        public IActionResult GetBusesByColor(string color)
        {
            var buses = vehicleRepository.GetBusesByColor(color);
            return Ok(buses);
        }

        [HttpGet("boats/{color}")]
        public IActionResult GetBoatsByColor(string color)
        {
            var boats = vehicleRepository.GetBoatsByColor(color);
            return Ok(boats);
        }

        [HttpPost("cars/{carId}/headlights")]
        public IActionResult ChangeCarHeadlightState(int carId, [FromBody] bool on)
        {
            vehicleRepository.TurnOnOffCarHeadlights(carId, on);
            return Ok();
        }

        [HttpDelete("cars/{carId}")]
        public IActionResult DeleteCar(int carId)
        {
            vehicleRepository.DeleteCar(carId);
            return Ok();
        }
    }
}