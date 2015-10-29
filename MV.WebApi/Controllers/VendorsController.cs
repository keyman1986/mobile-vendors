﻿using System;
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
            },
            new Vendor()
            {
                Id = 1002,
                Name = "AAAAArchie's Place",
                Address = "207 S 10th St, Boise, ID, 83702",
                GoogleLink = "http://maps.google.com/?q=43.6160037%2C%20-116.2088137%20(%22Caldwell+Farmers+Market%22)",
          //                   "https://www.google.com/maps/place/207+S+10th+St,+Boise,+ID+83702/@43.6160037,-116.2088137,17z/data=!3m1!4b1!4m2!3m1!1s0x54aef8e5a39c02d1:0xf53cbd3aed5854a",
                Website = "http://archies-place.com/",
                Products = "Vegan, Vegetarian, and Gluten Free friendly items; Soups; Griddled Cheese; Chicken meals; Pork meals;",
                Schedule = "05/13/2015 to 09/23/2015 Wed: 3:00 PM-7:00 PM;<br> <br> <br> "
            },
            new Vendor()
            {
                Id = 1003,
                Name = "Waffle Addiction",
                Address = "10577 Fairview Ave, Boise, ID, 83704",
                GoogleLink = "http://maps.google.com/?q=43.6191189%2C%20-116.3160927%20(%22Caldwell+Farmers+Market%22)",
           //                 "https://www.google.com/maps/place/10577+W+Fairview+Ave,+Boise,+ID+83704/@43.6191189,-116.3160927,17z/data=!3m1!4b1!4m2!3m1!1s0x54ae55d440636ebd:0x9cd82f1bca9f8d71",
                Website = "http://www.yelp.com/biz/waffle-addiction-boise-4",
                Products = "Unique sweet and savory waffles",
                Schedule = "Mon: Closed, Tue: Closed, Wed 7:00 am - 5:00 pm, Thu: 7:00 am - 5:00 pm, Fri: 8:00 am - 6:00 pm, Sat: 9:00 am - 5:00 pm, Sun: 10:00 am - 4:00 pm;<br> <br> <br> "
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
