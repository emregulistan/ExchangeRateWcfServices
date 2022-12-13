using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExchangeRate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (KurService.KurServiceClient serviceClient = new KurService.KurServiceClient())
            {
                if(TempData["Kurlar"] != null)
                {
                    ViewBag.Kurlar = (List<double>)TempData["Kurlar"];
                }
                else
                {
                    ViewBag.Kurlar = new List<double>();
                }
                var model = serviceClient.ParaBirimleriGetir().ToList();
                return View(model);
            }
        }

        public ActionResult KurGetir(string paraBirimi)
        {
            using (KurService.KurServiceClient serviceClient = new KurService.KurServiceClient())
            {
                var model = serviceClient.KurlariGetir(paraBirimi).ToList();
                TempData["Kurlar"] = model;
                return RedirectToAction("Index");
            }
        }
    }
}