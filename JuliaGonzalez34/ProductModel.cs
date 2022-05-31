using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuliaGonzalez34
{
    public class ProductModel
    {
            public ProductModel(string name, string description, string category, int price)
        {
            this.Name = name;
            this.Description = description;
            this.Category = category;
            this.Price = price;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }

    }
}
