using BobTheBuilderCalculatorMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.Repositories
{
    public class AddressRepository : EntityRepositiory<Address>
    {
        public AddressRepository(Context context)
            :base(context)
        {
        }
    }
}
