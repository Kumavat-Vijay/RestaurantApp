using RestaurantMvc.Models;
using RestaurantMvc.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly RestaurantEntities restaurantDBEntities;
        public HomeController()
        {
            restaurantDBEntities = new RestaurantEntities();
        }
        // GET: Home
        public ActionResult Index()
        {
            CustomerRepository customerRepository = new CustomerRepository();
            ItemRepository itemRepository = new ItemRepository();
            PaymentTypeRepository paymentTypeRepository = new PaymentTypeRepository();
            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (customerRepository.GetAllCustomer(),itemRepository.GetAllItem(),paymentTypeRepository.GetAllPaymentType());
            return View(objMultipleModels);
        }

        public JsonResult getItemUnitPrice(int itemId)
        {
            decimal UnitPrice = restaurantDBEntities.Items.Single(s => s.ItemId == itemId).ItemPrice;
            return Json(UnitPrice, JsonRequestBehavior.AllowGet);
        }
    }
}