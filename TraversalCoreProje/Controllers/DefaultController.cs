using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class DefaultController : Controller
    {
        TestimonialManager tm = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var values = tm.TGetList();
            return View(values);
        }
    }
}
