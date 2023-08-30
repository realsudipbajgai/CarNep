using CarNep.Data.Helpers;
using CarNep.Data.repo;
using CarNep.Data.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CarNep.Controllers
{
    public class CartController : Controller
    {
        private readonly IVehicleServices _vehicleServices;

        public CartController(IVehicleServices vehicleServices)
        {
            _vehicleServices = vehicleServices;
        }
        public IActionResult Index()
        {
            var cartListVM=HttpContext.Session.GetJson<List<CartVM>>("cart_items");
            
            return View(cartListVM);
        }
    }
}
