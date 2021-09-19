using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models.ViewModels
{
    public class ProductUserVM
    {
        public ProductUserVM()
        {
            products = new List<Product>();
        }
        public ApplicationUser applicationUser { get; set; }
        public List<Product> products { get; set; }
    }
}
