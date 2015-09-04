using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercuryWebService;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            order.ticketGroupID = 774177979;
            order.quantity = 2;
            order.wholesalePrice = 100;
            order.externalPONumber = 1121222;
            order.retailCustomerCity = "Gaithersburg";
            order.retailCustomerCountry = "USA";
            order.retailCustomerName = "Eli Vaknin";
            order.retailCustomerPhone = "(240) 715-8197";
            order.Place();

        }
    }
}
