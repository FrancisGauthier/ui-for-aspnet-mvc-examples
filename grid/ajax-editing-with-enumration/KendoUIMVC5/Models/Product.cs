using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIMVC5.Models
{
    public class Product
    {
        public Product(int iD, string name, Category category)
        {
            ID = iD;
            Name = name;
            Category = category;
        }
        public Product()
        {
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }

    }
}