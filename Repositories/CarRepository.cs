using RideSharingApplication.Data;
using RideSharingApplication.Models;
using RideSharingApplication.Repositories.Interfaces;

namespace RideSharingApplication.Repositories
{
    public class CarRepository : RepositoryBase<Car>, ICarRepository
    {

        public CarRepository(ApplicationDbContext carContext) : base(carContext) { }

    }
}
