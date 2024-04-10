using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.Persistence.Contrants;
using TailorMe.Domain.Entites;
using TailorMe.Persistence.Persistence;

namespace TailorMe.Persistence.Repositories
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PersonRepository(ApplicationDbContext dbContext) : 
            base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
