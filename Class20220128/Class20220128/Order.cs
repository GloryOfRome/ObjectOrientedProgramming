using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220128
{
    public enum OrderStatus
    {
        Placed,//放置
        Shipped,//销售中
        Recieved,//收到
        Returned//返回
    }
    class Order
    {
        public int OrderNumber;
        public DateTime PlacementTime;//上架时间
        public int CustomerId;//客户objest
        public OrderStatus Status;//状态
        public double TotalCost;//总成本

        public List<Product> Products;
        public Customer Customer;

    }
}
