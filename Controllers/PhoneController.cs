using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplication.Models;
namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            var phoneList = new List<Phone>
           {
               new Phone { PhoneId = 01 ,PhoneName = "Samsung",Manufacturer = "Samsung", DateReleased = DateTime.Now },
               new Phone {PhoneId = 02 , PhoneName = "Razor",Manufacturer = "Razor", DateReleased = DateTime.Now},
               new Phone {PhoneId = 03, PhoneName = "Rog", Manufacturer = "Asus", DateReleased = DateTime.Now},
           };
            return View(phoneList);
          
        }
    }
}