using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Web.Models.Domain;

namespace SEDC.PizzaApp.Web.Controllers
{
    
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      

        public IActionResult Empty()
        {
            return new EmptyResult();
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index","Home");
        }

        public IActionResult Details(int? id) 
        {
           if (id == null)
            {
                return RedirectToAction("Empty");
            }

           return View("Index");
        }

        public IActionResult JsonData() 
        {
            Pizza pizza = new Pizza()
            {
                Id = 1,
                Name = "PizzaTest",
                Price = 100,
                IsOnPromotion = false,


            };
            return new JsonResult(pizza);
        }
    }
}
