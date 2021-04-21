using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        //Retrieve one order
        public Order Retrieve(int orderId)
        {
            // Create the instance of the Order Class
            // Passin the requested Id
            Order order = new Order(orderId);

            // Code that retrieves the defined order

            // Temporary hard-coded values to return a populated order
            if (orderId == 10)
            {
                // Used this for hard-coded values
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 7, 8, 10, 18, 00, 00,
                    new TimeSpan(11, 0, 0));
            }
            return order;

        }

        // saves current order
        public bool Save(Order order)
        {
            var success = true;
            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
                    {
                        // Call an insert stored Procedure
                    }
                    else
                    {
                        // call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
