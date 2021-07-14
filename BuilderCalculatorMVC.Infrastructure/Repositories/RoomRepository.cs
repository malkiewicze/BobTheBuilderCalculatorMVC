using BuilderCalculatorMVC.Domain.Interfaces;
using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.Repositories
{
    class RoomRepository :EntityRepository<Room>, IRoomRepository
    {
        public RoomRepository(Context context)
            :base(context)
        {
        }
    }
}
