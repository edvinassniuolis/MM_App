using Log;
using OrderInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFOrderService" in both code and config file together.
    public class WCFOrderService : IWCFOrderService
    {

        public List<string> ListOrders()
        {
            var orderList = new List<string>();
            try
            {
                Logger.Info("ListOrders() has been called by client");

                using (var database = new MMDatabaseEntities())
                {
                    var orders = from order in database.Orders
                                 select order.CustomerName;

                    orderList = orders.ToList();
                }
                return orderList;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                throw;
            }
        }

        public OrderData GetOrder(int id)
        {
            try
            {
                OrderData order = null;
                using (var database = new MMDatabaseEntities())
                {
                    var matchOrder = database.Orders.First((o) => o.OrderId == id);

                    order = new OrderData();
                    order.Id = matchOrder.OrderId;
                    order.CustomerName = matchOrder.CustomerName;
                    order.Product = matchOrder.Product;
                    order.Quantity = matchOrder.Quantity;

                }
                return order;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                throw;
            }
        }

    }
}
