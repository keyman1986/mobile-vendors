using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MV.WebApi.Models;

namespace MV.WebApi.Controllers
{
    public class VendorsController : ApiController
    {
        private Vendor[] _vendors = new Vendor[]
        {
            new Vendor()
            {
                Id = 1000,
                Name = "Blah Blah",
                Address = "Main Street and Linder, Kuna, Idaho, 83634",
                GoogleLink = "http://maps.google.com/?q=43.490515%2C%20-116.415209%20(%22Kuna+Farmers+Market%22)",
                Products =
                    "Baked goods; Crafts and/or woodworking items; Eggs; Fresh fruit and vegetables; Fresh and/or dried herbs; Honey; Canned or preserved fruits, vegetables, jams, jellies, preserves, salsas, pickles, dried fruit, etc.; Plants in containers; Prepared foods (for immediate consumption); Soap and/or body care products; Trees, shrubs",
                Schedule = "05/09/2015 to 09/26/2015 Sat: 9:00 AM-12:00 PM;<br> <br> <br> "
            },
            new Vendor()
            {
                Id = 1001,
                Name = "Foo Bar",
                Address = "7th Street and Blaine, Caldwell, Idaho, 83605",
                GoogleLink = "http://maps.google.com/?q=43.66542%2C%20-116.6892%20(%22Caldwell+Farmers+Market%22)",
                Products =
                    "Baked goods; Cheese and/or dairy products; Crafts and/or woodworking items; Cut flowers; Eggs; Fresh fruit and vegetables; Fresh and/or dried herbs; Honey; Canned or preserved fruits, vegetables, jams, jellies, preserves, salsas, pickles, dried fruit, etc.; Nuts; Plants in containers; Prepared foods (for immediate consumption); Soap and/or body care products; Trees, shrubs; Wine, beer, hard cider",
                Schedule = "05/13/2015 to 09/23/2015 Wed: 3:00 PM-7:00 PM;<br> <br> <br> "
            }

        };

        public IEnumerable<Vendor> Get()
        {
            return _vendors;
        }

        public Vendor Get(int id)
        {
            return _vendors.FirstOrDefault(x => x.Id == id);
        }
    }
}
