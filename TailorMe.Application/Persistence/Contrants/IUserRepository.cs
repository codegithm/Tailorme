using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Domain.Entites;

namespace TailorMe.Application.Persistence.Contrants
{
    public interface IUserRepository : IGenericRepository<User>
    {
    }
}
