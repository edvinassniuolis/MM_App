namespace OrderService
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new Host(typeof(WCFOrderService));
            host.Open();
        }


    }
}
