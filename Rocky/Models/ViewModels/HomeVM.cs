using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Category> categories { get; set; }
        public IEnumerable<Product> products { get; set; }
    }
}
