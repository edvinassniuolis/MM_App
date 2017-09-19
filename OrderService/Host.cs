using Log;
using System;
using System.ServiceModel;

namespace OrderService
{
    public class Host
    {
        private readonly ServiceHost _host;

        public Host(Type type)
        {
            _host = new ServiceHost(type);
        }
        public void Open()
        {
            try
            {
                using (_host)
                {
                    _host.Open();

                    Logger.Info("Server Opened");
                    Console.WriteLine("Server is opened\n<Press any key to close server>");
                    Console.ReadLine();
                    Logger.Info("Server Closed");
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                throw;
            }
        }
    }
}
