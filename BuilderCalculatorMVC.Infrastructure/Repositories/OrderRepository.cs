using BuilderCalculatorMVC.Domain.Models;
using BuilderCalculatorMVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BuilderCalculatorMVC.Infrastructure.Repositories
{
    public class OrderRepository : EntityRepository<Order>, IOrderRepository
    {
        public OrderRepository(Context context)
            : base(context)
        {
        }

    }
}
