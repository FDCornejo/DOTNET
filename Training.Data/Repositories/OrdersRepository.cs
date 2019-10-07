using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Repositories
{
    public class OrdersRepository
    {
        private readonly StoreContext _StoreContext;

        public OrdersRepository(StoreContext storeContext)
        {
            _StoreContext = storeContext;
        }
    }
}
