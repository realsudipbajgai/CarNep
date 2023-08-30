using CarNep.Data.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CarNep.Controllers
{
    public class AdminBrandsController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
