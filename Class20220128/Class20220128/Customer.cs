using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220128
{
    class Customer
    {
        public int Id;
        public string Name;
        public string Address;
        public string Email;
        public string PaymentInfo;//付款信息--可以再建个类

        //public List<Product> Products;
        public List<Order> Orders;
    }
}
