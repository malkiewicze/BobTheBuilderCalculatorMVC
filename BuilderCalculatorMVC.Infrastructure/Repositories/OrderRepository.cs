using BobTheBuilderCalculatorMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.Repositories
{
    public class OrderRepository : EntityRepositiory<Order>
    {
        public OrderRepository(Context context)
            : base(context)
        {
        }
    }
}
