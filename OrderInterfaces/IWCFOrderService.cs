﻿using System.Collections.Generic;
using System.ServiceModel;

namespace OrderService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFOrderService" in both code and config file together.
    [ServiceContract]
    public interface IWCFOrderService
    {
        [OperationContract]
        List<string> ListOrders();
    }
}
