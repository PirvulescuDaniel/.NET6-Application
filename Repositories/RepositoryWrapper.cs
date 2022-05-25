using RideSharingApplication.Data;
using RideSharingApplication.Models;
using RideSharingApplication.Repositories.Interfaces;

namespace RideSharingApplication.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        private ApplicationDbContext dbContext;

        private ITripRepository? tripRepository;
        private ICarRepository? carRepository;

        public ITripRepository TripRepository
        {
            get
            { 
                if(tripRepository == null)
                {
                    tripRepository = new TripRepository(dbContext);
                }

                return tripRepository;
            }
        }

        public ICarRepository CarRepository
        {
            get
            {
                if (carRepository == null)
                {
                    carRepository = new CarRepository(dbContext);
                }

                return carRepository;
            }
        }

        public RepositoryWrapper(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

    }
}
