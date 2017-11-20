using FactoryDI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FactoryDI.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly CarService _carService;

        public CarController(CarService carService)
        {
            _carService = carService;
        }

        [HttpPost, Route("")]
        public IActionResult CreateTruck()
        {
            var type = CarType.Truck;
            var car = _carService.CreateCar(type).Create();
            return Ok(car);
        }
    }
}