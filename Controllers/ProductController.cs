using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Deneme_WİHTOOP__Product.Controllers
    {
    public class ProductController : Controller
        {
        ProductManager productManager = new ProductManager(new EfProductDal());

        public IActionResult Index()
            {
            var values = productManager.TGetList();
            return View(values);
            }

        [HttpGet]
        public IActionResult AddProduct()
            {
            return View();
            }
        [HttpPost]
        public IActionResult AddProduct(Product p)
            {
            productManager.TInsert(p);
            return RedirectToAction("Index");
            }
        }
    }
