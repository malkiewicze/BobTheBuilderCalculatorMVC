using BuilderCalculatorMVC.Domain.Interfaces;
using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.Repositories
{
    public class WorkRepository : EntityRepository<Work>, IWorkRepository
    {
        public WorkRepository(Context context)
            : base(context)
        {
        }
    }
}
