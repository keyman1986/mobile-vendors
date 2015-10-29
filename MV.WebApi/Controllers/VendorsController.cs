using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MV.WebApi.Models;
using System.Web.Http.Cors;

namespace MV.WebApi.Controllers
{
    [AllowAnonymous]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class VendorsController : ApiController
    {
        public List<Vendor> VendorList = new List<Vendor>();

        private void _addDefaultVendors()
        {
            var a = new Vendor("Blah Blah", "Main Street and Linder, Kuna, Idaho, 83634",
                "http://maps.google.com/?q=43.490515%2C%20-116.415209%20(%22Kuna+Farmers+Market%22)", "",
                "05/09/2015 to 09/26/2015 Sat: 9:00 AM-12:00 PM",
                "Baked goods; Crafts and/or woodworking items; Eggs; Fresh fruit and vegetables; Fresh and/or dried herbs; Honey; Canned or preserved fruits, vegetables, jams, jellies, preserves, salsas, pickles, dried fruit, etc.; Plants in containers; Prepared foods (for immediate consumption); Soap and/or body care products; Trees, shrubs");
            var b = new Vendor("Archie's Place", "207 S 10th St, Boise, ID, 83702",
                "http://maps.google.com/?q=43.6160037%2C%20-116.2088137%20(%22Caldwell+Farmers+Market%22)",
                "http://archies-place.com/",
                "Vegan, Vegetarian, and Gluten Free friendly items; Soups; Griddled Cheese; Chicken meals; Pork meals;",
                "05/13/2015 to 09/23/2015 Wed: 3:00 PM-7:00 PM");
            var c = new Vendor("Waffle Addiction", "10577 Fairview Ave, Boise, ID, 83704",
                "http://www.yelp.com/biz/waffle-addiction-boise-4",
                "http://maps.google.com/?q=43.6191189%2C%20-116.3160927%20", "Unique sweet and savory waffles",
                "Mon: Closed, Tue: Closed, Wed 7:00 am - 5:00 pm, Thu: 7:00 am - 5:00 pm, Fri: 8:00 am - 6:00 pm, Sat: 9:00 am - 5:00 pm, Sun: 10:00 am - 4:00 pm");
            VendorList.Add(a);
            VendorList.Add(b);
            VendorList.Add(c);
        }
        [HttpGet]
        [Route("add-defaults")]
        public void AddDefaultVendors()
        {
            _addDefaultVendors();
        }

        public IEnumerable<Vendor> Get()
        {
            return VendorList;
        }

        public Vendor Get(int id)
        {
            return VendorList.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        [Route("add")]
        public Vendor Post(string name)
        {
            //Vendor n = new Vendor(newVendor.Name, newVendor.Address, newVendor.GoogleLink, newVendor.Website, newVendor.Products,
            //    newVendor.Schedule);
            var n = new Vendor(name);
            VendorList.Add(n);
            return n;

        }


    }
}
