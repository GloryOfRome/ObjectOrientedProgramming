using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220128
{
    class Product
    {
        public int Id;
        public string Name;
        public double Price;
        public int Stock;//库存
        public double TotalRating;//总评分
        public int CategoryId;//类别Id

        public Category Category;
        public List<ProductOrder> ProductOrders;




    }
}
