using BuilderCalculatorMVC.Domain.Interfaces;
using BuilderCalculatorMVC.Domain.Models;
using System.Linq;


namespace BuilderCalculatorMVC.Infrastructure.Repositories
{
    public class ClientRepository : EntityRepository<Client>, IClientRepository
    {

        public ClientRepository(Context context)
            : base(context)
        {
        }

        public IQueryable<Client> GetAllActiveClients()
        {
            return GetAll().Where(c => c.IsActive);
        }
    }
}
