using CarNep.Data.repo;
using Microsoft.AspNetCore.Mvc;

namespace CarNep.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleServices _vehicleServices;

        public VehicleController(IVehicleServices vehicleServices)
        {
            _vehicleServices = vehicleServices;
        }
        public IActionResult Index()
        {
            return View(_vehicleServices.GetAll());
        }

        public IActionResult Details(int id)
        {
            var vehicle = _vehicleServices.GetById(id);
            return View(vehicle);
        }
    }
}
