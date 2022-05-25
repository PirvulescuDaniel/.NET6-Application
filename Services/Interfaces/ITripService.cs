

using RideSharingApplication.Models;

namespace AspNetCoreServicesApp.Services.Interfaces
{
    public interface ITripService
    {
         List<Trip> GetTripsByName(string tripName);

         List<Trip> GetAllTrips();

        void AddTrip(Trip _trip);
    }
}
