using AspNetCoreServicesApp.Services.Interfaces;
using RideSharingApplication.Models;
using RideSharingApplication.Repositories.Interfaces;

namespace RideSharingApplication.Services
{
    public class TripService : ITripService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public TripService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public List<Trip> GetTripsByName(string tripName)
        {
            var trips = new List<Trip>();

            trips = _repositoryWrapper.TripRepository.FindByCondition(t => t.trip_name.Contains(tripName)).ToList();

            return trips;
        }

        public List<Trip> GetAllTrips()
        {
            var trips = new List<Trip>();

            trips = _repositoryWrapper.TripRepository.FindAll().ToList();

            return trips;
        }

        public void AddTrip(Trip _trip)
        {
            _repositoryWrapper.TripRepository.Create(_trip);
            _repositoryWrapper.Save();
        }
    }
}
