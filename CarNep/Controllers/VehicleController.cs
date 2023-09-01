using CarNep.Data.Helpers;
using DAL.GenericRepo;
using DAL.Services;
using DAL.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarNep.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IUnitOfWork _work;

        public VehicleController(IUnitOfWork work)
        {
            _work = work;
        }
        public IActionResult Index()
        {
            return View(_work.VehicleServices.GetAllVehicles());
        }

        public IActionResult Details(int id)
        {
            var vehicle = _work.VehicleServices.GetVehicleById(id);
            return View(vehicle);
        }

        public IActionResult AddToCart(int id)
        {
            //store product info to cart items
            var vehicle = _work.VehicleServices.GetVehicleById(id);
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
