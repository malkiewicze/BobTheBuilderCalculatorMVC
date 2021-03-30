using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.Repositories
{
    public class WorkRepository : EntityRepositiory<Work>
    {
        public WorkRepository(Context context)
            : base(context)
        {
        }
    }
}
