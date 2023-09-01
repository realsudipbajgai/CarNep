using CarNep.Data.Helpers;
using CarNep.Data.repo;
using CarNep.Data.ViewModel;
using Microsoft.AspNetCore.Authorization;
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
            return View(_vehicleServices.GetAllVehicles());
        }

        public IActionResult Details(int id)
        {
            var vehicle = _vehicleServices.GetVehicleById(id);
            return View(vehicle);
        }

        public IActionResult AddToCart(int id)
        {
            //store product info to cart items
            var vehicle = _vehicleServices.GetVehicleById(id);
            List<CartVM> cart_items = HttpContext.Session.GetJson<List<CartVM>>("cart_items")??new List<CartVM>();
            CartVM cartVM = new CartVM()
            {
                Price = vehicle.Price,
                ProductName = vehicle.Brand.Name+" "+vehicle.Make + " " + vehicle.Model,
                Image = vehicle.Image
            };
           cart_items.Add(cartVM);
           HttpContext.Session.SetJson("cart_items",cart_items);
           return Redirect("/cart");
        }
    }
}
