using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeftMenu1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ForOrder()
        {
            return View();
        }
        public ActionResult KTN()
        {
            return View();
        }
        public ActionResult PersonalCabinet()
        {
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult PotentialClient()
        {
            return View();

        }
        public ActionResult PlaceOrder()
        {
            return View();
        }
        public ActionResult PotentialProducer()
        {
            return View();
        }
        public ActionResult SellerSignUp()
        {
            return View();
        }
        public ActionResult PersonSignUp()
        {
            return View();
        }
        public ActionResult SellerOffers()
        {
            return View();
        }
        public ActionResult PotentialProducerOffer()
        {
            return View();
        }
        public ActionResult KTNPotensialProducer()
        {
            return View();
        }

        public ActionResult LegalProducer()
        {
            return View();
        }

        public ActionResult LegalSellerSignUp()
        {
            return View();
        }
        
         public ActionResult LegalPersonSignUp()
        {
            return View();
        }
        public ActionResult LegalPotentialProducer()
        {
            return View();
        }
    }
}