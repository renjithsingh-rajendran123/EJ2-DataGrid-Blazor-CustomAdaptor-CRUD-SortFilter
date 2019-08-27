using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class OrdersDetails
    {
        public OrdersDetails()
        {

        }
        public OrdersDetails(int OrderID, string CustomerId, double Freight, DateTime OrderDate, string ShipCountry)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;
            this.Freight = Freight;
            this.OrderDate = OrderDate;
            this.ShipCountry = ShipCountry;
        }
        public static List<OrdersDetails> GetAllRecords()
        {
            List<OrdersDetails> order = new List<OrdersDetails>();
            int code = 10000;
            for (int i = 1; i < 5; i++)
            {
                order.Add(new OrdersDetails(code + 1, "ALFKI", 2.3 * i, new DateTime(1991, 05, 15), "Denmark"));
                order.Add(new OrdersDetails(code + 2, "ANATR", 3.3 * i, new DateTime(1990, 04, 04), "Brazil"));
                order.Add(new OrdersDetails(code + 3, "ANTON", 4.3 * i, new DateTime(1957, 11, 30), "Germany"));
                order.Add(new OrdersDetails(code + 4, "BLONP", 5.3 * i, new DateTime(1930, 10, 22), "Austria"));
                order.Add(new OrdersDetails(code + 5, "BOLID", 6.3 * i, new DateTime(1953, 02, 18), "Switzerland"));
                code += 5;
            }
            return order;
        }

        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public double? Freight { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCountry { get; set; }
    }
}
