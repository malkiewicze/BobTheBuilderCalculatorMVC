﻿using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderCalculatorMVC.Domain.Interfaces
{
    public interface IClientRepository : IEntityRepository<Client>
    {
        IQueryable<Client> GetAllActiveClients();
    }
}
