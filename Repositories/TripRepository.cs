using RideSharingApplication.Data;
using RideSharingApplication.Models;
using RideSharingApplication.Repositories.Interfaces;

namespace RideSharingApplication.Repositories
{
    public class TripRepository : RepositoryBase<Trip> , ITripRepository
    {

        public TripRepository(ApplicationDbContext tripContext) : base(tripContext) { }

    }
}
