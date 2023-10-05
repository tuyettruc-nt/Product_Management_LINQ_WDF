using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProduct
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public string Origin { get; set; }
        public DateTime Date { get; set; }
    }
}
