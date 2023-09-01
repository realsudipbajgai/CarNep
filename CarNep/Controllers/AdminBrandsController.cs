using DAL.GenericRepo;
using DAL.Services;
using DAL.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CarNep.Controllers
{
    public class AdminBrandsController : AdminBaseController
    {
        private readonly IUnitOfWork _work;

        public AdminBrandsController(IUnitOfWork work)
        {
            _work = work;
        }
        public IActionResult Index()
        {
            var brands = _work.BrandsServices.GetAllBrands();
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
            _work.BrandsServices.AddBrandInfo(brand);
            _work.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(_work.BrandsServices.GetBrandById(id));
        }

        [HttpPost]
        public IActionResult Update(BrandVM brand)
        {
            _work.BrandsServices.UpdateBrand(brand);
            _work.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(_work.BrandsServices.GetBrandById(id));
        }
        public IActionResult Delete(int id)
        {
            _work.BrandsServices.DeleteBrandInfo(id);
            _work.Save();
            return RedirectToAction("Index");
        }
    }
}
