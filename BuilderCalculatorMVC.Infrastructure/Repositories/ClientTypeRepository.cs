using BuilderCalculatorMVC.Domain.Interfaces;
using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.Repositories
{
    class ClientTypeRepository :EntityRepository<ClientType>, IClientTypeRepository
    {
        public ClientTypeRepository(Context context)
            : base(context)
        {
        }
    }
}
