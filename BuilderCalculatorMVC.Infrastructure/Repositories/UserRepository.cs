using BuilderCalculatorMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.Repositories
{
    public class UserRepository : EntityRepositiory<AppUser>
    {
        public UserRepository(Context context)
            :base(context)
        {
        }
    }
}
