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
    public class TopMeasurementRepository : GenericRepository<TopMeasurement>, ITopMeasurementRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TopMeasurementRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
