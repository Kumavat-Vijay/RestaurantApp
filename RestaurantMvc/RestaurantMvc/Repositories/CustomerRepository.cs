using RestaurantMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantMvc.Repositories
{
    public class CustomerRepository
    {
        private readonly RestaurantEntities restaurantDBEntities;
        public CustomerRepository()
        {
            restaurantDBEntities = new RestaurantEntities();
        }
        public IEnumerable<SelectListItem> GetAllCustomer()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in restaurantDBEntities.Customers
                                  select new SelectListItem()
                                  {
                                      Text = obj.CustomerName,
                                      Value = obj.CustomerId.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;
        }
    }
}