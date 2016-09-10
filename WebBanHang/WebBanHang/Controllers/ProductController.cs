using System.Collections.Generic;
using WebBanHang.Models;
using System.Linq;
using System.Web.Mvc;

namespace WebBanHang.Controllers
{
    public class ProductController : Controller
    {
        SalesContext sales = new SalesContext();

        // GET: Product/ ByCat / id
        public ActionResult ByCat(int id)
        {
            List<Product> list = sales.Products
                                      .Where(p => p.CateID == id)
                                      .ToList();
            return View(list);
        }
        // GET: Product/ Detail / id
        public ActionResult Detail(int id)
        {
            List<Product> pro = sales.Products
                                      .Where(p => p.ProID == id)
                                      .ToList();
            return View(pro);
        }
    }
}
