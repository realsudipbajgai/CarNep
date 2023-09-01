using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarNep.Controllers
{
    public class AdminCategoriesController : Controller
    {
        // GET: AdminCategoriesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminCategoriesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminCategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminCategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminCategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminCategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminCategoriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminCategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
