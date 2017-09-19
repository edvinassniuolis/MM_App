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

            var products = proxy.ListOrders();
            foreach (var i in products)
            {
                Console.WriteLine(i);
            }

            //calls the server

            Console.ReadLine();

        }
    }
}
