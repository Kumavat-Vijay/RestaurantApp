using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantMvc.ViewModel
{
    public class ItemViewModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public Decimal ItemPrice { get; set; }
    }
}