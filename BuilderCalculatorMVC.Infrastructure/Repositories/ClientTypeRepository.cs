using BobTheBuilderCalculatorMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.Repositories
{
    class ClientTypeRepository :EntityRepositiory<ClientType>
    {
        public ClientTypeRepository(Context context)
            : base(context)
        {
        }
    }
}
