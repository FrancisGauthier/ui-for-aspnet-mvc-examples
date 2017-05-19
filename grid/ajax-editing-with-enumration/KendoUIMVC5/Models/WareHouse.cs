using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIMVC5.Models
{
    public class WareHouse
    {
        public WareHouse(string name, IEnumerable<Product> products)
        {
            Name = name;
            Products = products;
        }
        public WareHouse()
        {

        }

        public string Name {get;set;}

        public string Toto { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}