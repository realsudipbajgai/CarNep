using CarNep.Data.repo;
using CarNep.Data.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CarNep.Controllers
{
    public class AdminBrandsController : AdminBaseController
    {
        private readonly IBrandsServices _brandsServices;

        public AdminBrandsController(IBrandsServices brandsServices)
        {
            _brandsServices = brandsServices;
        }
        public IActionResult Index()
        {
            var brands = _brandsServices.GetAll();
            return View(brands);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BrandVM brand)
        {
            if (!ModelState.IsValid)
            {
                return View(brand);
            }
            _brandsServices.AddBrand(brand);
            return RedirectToAction("Index");
        }
    }
}
