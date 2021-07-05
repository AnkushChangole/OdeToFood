using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Web.Models
{
    public class GreetingViewModal
    {
        public IEnumerable<Restaurant> restaurants { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}