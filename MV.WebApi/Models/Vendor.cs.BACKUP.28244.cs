using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace MV.WebApi.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string GoogleLink { get; set; }
        public string Website { get; set; }
        public string Products { get; set; }
        public string Schedule { get; set; }
        public VendorType VendorType { get; set; }
<<<<<<< HEAD

        private int _idCount = 0; 

        public Vendor(string name, string address = "", string googleLink = "", string website = "", string products = "", string schedule = "", VendorType vendorType = VendorType.FoodTruck)  
        {
            Id = _idCount++;
            Name = name;
            Address = address;
            GoogleLink = googleLink;
            Website = website;
            Products = products;
            Schedule = schedule;
            VendorType = vendorType;
        }

=======
>>>>>>> 33d8fddd6ad58d16a8154155f79d8f8af4610fc8
    }


        /*

        marketdetails: {
        Address: "Main Street and Linder, Kuna, Idaho, 83634",
        GoogleLink: "http://maps.google.com/?q=43.490515%2C%20-116.415209%20(%22Kuna+Farmers+Market%22)",
        Products: "Baked goods; Crafts and/or woodworking items; Eggs; Fresh fruit and vegetables; Fresh and/or dried herbs; Honey; Canned or preserved fruits, vegetables, jams, jellies, preserves, salsas, pickles, dried fruit, etc.; Plants in containers; Prepared foods (for immediate consumption); Soap and/or body care products; Trees, shrubs",
        Schedule: "05/09/2015 to 09/26/2015 Sat: 9:00 AM-12:00 PM;<br> <br> <br> "
        }*/
}
 