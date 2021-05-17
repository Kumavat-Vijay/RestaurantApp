using RestaurantMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantMvc.Repositories
{
    public class ItemRepository
    {
        private readonly RestaurantEntities restaurantDBEntities;
        public ItemRepository()
        {
            restaurantDBEntities = new RestaurantEntities();
        }
        public IEnumerable<SelectListItem> GetAllItem()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in restaurantDBEntities.Items
                                  select new SelectListItem()
                                  {
                                      Text = obj.ItemName,
                                      Value = obj.ItemId.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;
        }
    }
}