using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.Repositories
{
    public class ClientRepository : EntityRepositiory<Client>
    {
        public ClientRepository(Context context)
            : base(context)
        {
        }
    }
}
