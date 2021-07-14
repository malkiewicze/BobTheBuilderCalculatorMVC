using BuilderCalculatorMVC.Domain.Interfaces;
using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.Repositories
{
    public class AddressRepository : EntityRepository<Address>, IAddressRepository
    {
        public AddressRepository(Context context)
            :base(context)
        {
        }
    }
}
