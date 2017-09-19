using OrderService;
using System;
using System.ServiceModel;

namespace OrdersClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IWCFOrderService> channelFactory = new ChannelFactory<IWCFOrderService>("OrderServiceEndpoint");

            IWCFOrderService proxy = channelFactory.CreateChannel();

            //calls the server
            var products = proxy.ListOrders();
            foreach (var i in products)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
