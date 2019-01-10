using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyImageClient.Controllers
{
    public class OrderController : Controller
    {
        // Action for showing all orders
        public ActionResult Index()
        {
            return View();
        }

        /* 
         * [Order Step 1]
         * Action for uploading the images
         */        
        public ActionResult Upload()
        {
            return View();
        }

        /*
         * [Order Step 2]
         * Action for choosing the printing size and number of copies
         */         
        public ActionResult ChooseImageDetails()
        {
            return View();
        }

        /*
         * [Order Step 3]
         * Action for getting the shiping location and date of delivery
         */       
        public ActionResult GetShipInfo()
        {
            return View();
        }

        /*
         * [Order Step 4]
         * Action for adding the order to Cart
         */        
        public ActionResult AddToCart()
        {
            return View();
        }

        /*
         * [Order Step 5]
         * Action for geting the payment mode
         */
        public ActionResult Payment()
        {
            return View();
        }


    }
}
