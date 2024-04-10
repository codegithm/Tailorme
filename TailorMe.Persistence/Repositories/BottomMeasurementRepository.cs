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
    public class BottomMeasurementRepository : GenericRepository<BottomMeasurement>, IBottomMeasurementRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public BottomMeasurementRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
