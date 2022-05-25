using RideSharingApplication.Models;
using RideSharingApplication.Repositories.Interfaces;
using RideSharingApplication.Services.Interfaces;

namespace RideSharingApplication.Services
{
    public class CarService : ICarService
    {

        private IRepositoryWrapper _repositoryWrapper;

        public CarService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public List<Car> getAllCars()
        {
            var cars = new List<Car>();

            cars = _repositoryWrapper.CarRepository.FindAll().ToList();

            return cars;
        }

    }
}
